using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_43f0-56833091")]
        public void /* sys */ Method_1019_43f0()
        {
            ii(0x1019_43f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_43f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_43f3, 1); pushd(esi);                             /* push esi */
            ii(0x1019_43f4, 1); pushd(edi);                             /* push edi */
            ii(0x1019_43f5, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1019_43f8, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_43fa, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1019_43fc, 5); mov(edx, 0x100);                        /* mov edx, 0x100 */
            ii(0x1019_4401, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1019_4404, 4); mov(memw_a32[ss, ebp - 0x20], ax);      /* mov [ebp-0x20], ax */
            ii(0x1019_4408, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1019_440d, 4); mov(memw_a32[ss, ebp - 0x24], dx);      /* mov [ebp-0x24], dx */
            ii(0x1019_4411, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1019_4414, 5); calld(/* sys */ 0x1016_c606, -0x2_7e13); /* call 0x1016c606 */
            ii(0x1019_4419, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1019_441d, 2); if(jzd(0x1019_4436, 0x17)) goto l_0x1019_4436; /* jz 0x10194436 */
            ii(0x1019_441f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4421, 4); mov(ax, memw_a32[ss, ebp - 0x24]);      /* mov ax, [ebp-0x24] */
            ii(0x1019_4425, 2); mov(memd_a32[ds, ecx], eax);            /* mov [ecx], eax */
            ii(0x1019_4427, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4429, 3); mov(edx, memd_a32[ss, ebp + 0x8]);      /* mov edx, [ebp+0x8] */
            ii(0x1019_442c, 4); mov(ax, memw_a32[ss, ebp - 0x20]);      /* mov ax, [ebp-0x20] */
            ii(0x1019_4430, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1019_4432, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4434, 2); jmpd(0x1019_444d, 0x17); goto l_0x1019_444d; /* jmp 0x1019444d */
        l_0x1019_4436:
            ii(0x1019_4436, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1019_4439, 3); mov(memw_a32[ds, esi], ax);             /* mov [esi], ax */
            ii(0x1019_443c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_443e, 4); mov(ax, memw_a32[ss, ebp - 0x18]);      /* mov ax, [ebp-0x18] */
            ii(0x1019_4442, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_4444, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4446, 4); mov(ax, memw_a32[ss, ebp - 0x24]);      /* mov ax, [ebp-0x24] */
            ii(0x1019_444a, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
        l_0x1019_444d:
            ii(0x1019_444d, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1019_4450, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4451, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4452, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4453, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
