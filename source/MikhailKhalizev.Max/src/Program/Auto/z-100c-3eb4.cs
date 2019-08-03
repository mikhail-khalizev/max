using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d8826748-a9b1-4861-9816-db0dfcb1abb2")]
        public void Method_100c_3eb4()
        {
            ii(0x100c_3eb4, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100c_3eb9, 5); calld(Definitions.sys_check_available_stack_size, 0xa1e94); /* call 0x10165d52 */
            ii(0x100c_3ebe, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_3ebf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_3ec0, 1); pushd(edx);                             /* push edx */
            ii(0x100c_3ec1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_3ec2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_3ec3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_3ec4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_3ec6, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_3ecc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_3ecf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_3ed2, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_3ed5, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100c_3ed8, 5); jmpd_func(0x100c_4004, 0x127); return;  /* jmp 0x100c4004 */
        }
    }
}
