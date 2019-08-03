using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("065137d1-5b99-4af0-ab41-9ac9a9768501")]
        public void Method_100f_4a4c()
        {
            ii(0x100f_4a4c, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100f_4a51, 5); calld(Definitions.sys_check_available_stack_size, 0x712fc); /* call 0x10165d52 */
            ii(0x100f_4a56, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4a57, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4a58, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4a59, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4a5a, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4a5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4a5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4a5e, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100f_4a64, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4a66, 5); mov(eax, memd_a32[ds, 0x101b_87c3]);    /* mov eax, [0x101b87c3] */
            ii(0x100f_4a6b, 5); calld(0x100c_fb73, -0x24efd);           /* call 0x100cfb73 */
            ii(0x100f_4a70, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_4a77, 2); if(jnzd(0x100f_4a93, 0x1a)) goto l_0x100f_4a93; /* jnz 0x100f4a93 */
            ii(0x100f_4a79, 5); calld(0x100d_4e6c, -0x1fc12);           /* call 0x100d4e6c */
            ii(0x100f_4a7e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_4a80, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_4a82, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x100f_4a87, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x100f_4a8c, 5); calld(0x1010_5b00, 0x1106f);            /* call 0x10105b00 */
            ii(0x100f_4a91, 2); jmpd(0x100f_4aab, 0x18); goto l_0x100f_4aab; /* jmp 0x100f4aab */
        l_0x100f_4a93:
            ii(0x100f_4a93, 5); calld(0x100d_4e6c, -0x1fc2c);           /* call 0x100d4e6c */
            ii(0x100f_4a98, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_4a9a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_4a9c, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x100f_4aa1, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x100f_4aa6, 5); calld(0x1010_5b00, 0x11055);            /* call 0x10105b00 */
        l_0x100f_4aab:
            ii(0x100f_4aab, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4aac, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4aad, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4aae, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4aaf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4ab0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4ab1, 1); retd(); return;                         /* ret */
        }
    }
}