using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_cbbc-8efc2b99")]
        public void /* sys */ sys_display_apply_palette()
        {
            ii(0x1016_cbbc, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_cbbd, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_cbbe, 1);  push(edx);                            /* push edx */
            ii(0x1016_cbbf, 1);  push(esi);                            /* push esi */
            ii(0x1016_cbc0, 6);  sub(esp, 0x300);                      /* sub esp, 0x300 */
            ii(0x1016_cbc6, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
        l_0x1016_cbc8:
            ii(0x1016_cbc8, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1016_cbca, 2);  mov(cl, memb[ds, eax]);               /* mov cl, [eax] */
            ii(0x1016_cbcc, 6);  mov(cl, memb[ds, ecx + 0x101c_ffe0]); /* mov cl, [ecx+0x101cffe0] */
            ii(0x1016_cbd2, 3);  mov(memb[ss, esp + ebx], cl);         /* mov [esp+ebx], cl */
            ii(0x1016_cbd5, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1016_cbd6, 2);  mov(cl, memb[ds, eax]);               /* mov cl, [eax] */
            ii(0x1016_cbd8, 1);  inc(eax);                             /* inc eax */
            ii(0x1016_cbd9, 6);  mov(memb[ds, ebx + 0x101c_fcdf], cl); /* mov [ebx+0x101cfcdf], cl */
            ii(0x1016_cbdf, 6);  cmp(ebx, 0x300);                      /* cmp ebx, 0x300 */
            ii(0x1016_cbe5, 2);  if(jl(0x1016_cbc8, -0x1f)) goto l_0x1016_cbc8;/* jl 0x1016cbc8 */
            ii(0x1016_cbe7, 2);  mov(ecx, esp);                        /* mov ecx, esp */
            ii(0x1016_cbe9, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1016_cbeb, 5);  mov(esi, 0x3c9);                      /* mov esi, 0x3c9 */
        l_0x1016_cbf0:
            ii(0x1016_cbf0, 5);  mov(edx, 0x3c8);                      /* mov edx, 0x3c8 */
            ii(0x1016_cbf5, 2);  mov(al, bl);                          /* mov al, bl */
            ii(0x1016_cbf7, 1);  outb(dx, al);                         /* out dx, al */
            ii(0x1016_cbf8, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1016_cbfa, 2);  mov(al, memb[ds, ecx]);               /* mov al, [ecx] */
            ii(0x1016_cbfc, 1);  outb(dx, al);                         /* out dx, al */
            ii(0x1016_cbfd, 3);  mov(al, memb[ds, ecx + 1]);           /* mov al, [ecx+0x1] */
            ii(0x1016_cc00, 3);  add(ecx, 3);                          /* add ecx, 0x3 */
            ii(0x1016_cc03, 1);  outb(dx, al);                         /* out dx, al */
            ii(0x1016_cc04, 3);  mov(al, memb[ds, ecx - 1]);           /* mov al, [ecx-0x1] */
            ii(0x1016_cc07, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1016_cc08, 1);  outb(dx, al);                         /* out dx, al */
            ii(0x1016_cc09, 6);  cmp(ebx, 0x100);                      /* cmp ebx, 0x100 */
            ii(0x1016_cc0f, 2);  if(jl(0x1016_cbf0, -0x21)) goto l_0x1016_cbf0;/* jl 0x1016cbf0 */
            ii(0x1016_cc11, 6);  add(esp, 0x300);                      /* add esp, 0x300 */
            ii(0x1016_cc17, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_cc18, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_cc19, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_cc1a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_cc1b, 1);  ret();                                /* ret */
        }
    }
}
