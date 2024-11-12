import { DestroyRef, Directive, ElementRef, inject, OnInit, Renderer2 } from "@angular/core";
import { takeUntilDestroyed } from "@angular/core/rxjs-interop";
import { IdentityService } from "@identity";

@Directive({
  selector: "[hideLoggedIn]",
  standalone: true,
})
export class HideLoggedInDirective implements OnInit {
  #identityService = inject(IdentityService);
  #el = inject(ElementRef);
  #destroyRef = inject(DestroyRef);
  #renderer = inject(Renderer2);
  #originalDisplay = this.#el.nativeElement.style.display;

  ngOnInit() {
    this.#identityService
      .watchLoggedIn$()
      .pipe(takeUntilDestroyed(this.#destroyRef))
      .subscribe({
        next: loggedIn => {
          if (loggedIn) {
            this.#renderer.setStyle(this.#el.nativeElement, "display", "none");
          } else if (this.#originalDisplay?.length) {
            this.#renderer.setStyle(this.#el.nativeElement, "display", this.#originalDisplay);
          } else {
            this.#renderer.removeStyle(this.#el.nativeElement, "display");
          }
        },
      });
  }
}