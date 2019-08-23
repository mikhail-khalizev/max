using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4db6-a2bc0db4")]
        public void Method_100a_4db6()
        {
            ii(0x100a_4db6, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_4dbb, 5); calld(Definitions.sys_check_available_stack_size, 0xc_0f92); /* call 0x10165d52 */
            ii(0x100a_4dc0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_4dc1, 1); pushd(esi);                             /* push esi */
            ii(0x100a_4dc2, 1); pushd(edi);                             /* push edi */
            ii(0x100a_4dc3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_4dc4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4dc6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_4dcc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_4dcf, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_4dd2, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_4dd5, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_4dd9, 2); if(jzd(0x100a_4deb, 0x10)) goto l_0x100a_4deb; /* jz 0x100a4deb */
            ii(0x100a_4ddb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_4dde, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_4de1, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_4de4, 5); calld(0x100a_acf0, 0x5f07);             /* call 0x100aacf0 */
            ii(0x100a_4de9, 2); jmpd(0x100a_4df9, 0xe); goto l_0x100a_4df9; /* jmp 0x100a4df9 */
        l_0x100a_4deb:
            ii(0x100a_4deb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_4dee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_4df1, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_4df4, 5); calld(0x100a_acf0, 0x5ef7);             /* call 0x100aacf0 */
        l_0x100a_4df9:
            ii(0x100a_4df9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_4dfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_4dfc, 1); popd(edi);                              /* pop edi */
            ii(0x100a_4dfd, 1); popd(esi);                              /* pop esi */
            ii(0x100a_4dfe, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_4dff, 1); retd();                                 /* ret */
        }
    }
}
