using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a2c9-d196e339")]
        public void Method_1009_a2c9()
        {
            ii(0x1009_a2c9, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_a2ce, 5); calld(Definitions.sys_check_available_stack_size, 0xc_ba7f); /* call 0x10165d52 */
            ii(0x1009_a2d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a2d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a2d5, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a2d6, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a2d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a2d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a2da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_a2e0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_a2e3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_a2e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a2e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a2eb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a2ee, 5); calld(0x1013_ad71, 0xa_0a7e);           /* call 0x1013ad71 */
            ii(0x1009_a2f3, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a2f5, 2); if(jnzd(0x1009_a321, 0x2a)) goto l_0x1009_a321; /* jnz 0x1009a321 */
            ii(0x1009_a2f7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_a2fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a2fd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a300, 5); calld(0x1007_6630, -0x2_3cd5);          /* call 0x10076630 */
            ii(0x1009_a305, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_a308, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a30b, 5); calld(0x1015_27ed, 0xb_84dd);           /* call 0x101527ed */
            ii(0x1009_a310, 5); calld(0x1008_b0e4, -0xf231);            /* call 0x1008b0e4 */
            ii(0x1009_a315, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a317, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_a319, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a31c, 5); calld(0x100a_297d, 0x865c);             /* call 0x100a297d */
        l_0x1009_a321:
            ii(0x1009_a321, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a323, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a324, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a325, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a326, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a327, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a328, 1); retd();                                 /* ret */
        }
    }
}
