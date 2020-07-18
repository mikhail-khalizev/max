using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c995-b0f9248d")]
        public void /* sys */ Method_1016_c995()
        {
            ii(0x1016_c995, 1);  push(edx);                            /* push edx */
            ii(0x1016_c996, 1);  push(eax);                            /* push eax */
            ii(0x1016_c997, 5);  mov(edx, /* sys */ 0x1016_c778);      /* mov edx, 0x1016c778 */
            ii(0x1016_c99c, 4);  mov(ax, 0x3d01);                      /* mov ax, 0x3d01 */
            ii(0x1016_c9a0, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1016_c9a2, 3);  mov(bx, ax);                          /* mov bx, ax */
            ii(0x1016_c9a5, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_c9a6, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1016_c9a8, 1);  cld();                                /* cld */
        l_0x1016_c9a9:
            ii(0x1016_c9a9, 1);  lodsb();                              /* lodsb */
            ii(0x1016_c9aa, 2);  cmp(al, 0);                           /* cmp al, 0x0 */
            ii(0x1016_c9ac, 2);  if(jnz(0x1016_c9a9, -5)) goto l_0x1016_c9a9;/* jnz 0x1016c9a9 */
            ii(0x1016_c9ae, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x1016_c9b0, 2);  sub(ecx, edx);                        /* sub ecx, edx */
            ii(0x1016_c9b2, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1016_c9b3, 2);  mov(ah, 0x40);                        /* mov ah, 0x40 */
            ii(0x1016_c9b5, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1016_c9b7, 1);  pop(eax);                             /* pop eax */
        }
    }
}
