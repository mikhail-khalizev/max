using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d4efa45-0073-425f-acb3-cb71925e02cf")]
        public void Method_1016_3b41()
        {
            ii(0x1016_3b41, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1016_3b46, 5); calld(Definitions.sys_check_available_stack_size, 0x2207); /* call 0x10165d52 */
            ii(0x1016_3b4b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_3b4c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_3b4d, 1); pushd(esi);                             /* push esi */
            ii(0x1016_3b4e, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3b4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3b50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3b52, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1016_3b58, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_3b5b, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1016_3b5e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1016_3b61, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1016_3b64, 5); jmpd_func(0x1016_3c08, 0x9f); return;   /* jmp 0x10163c08 */
        }
    }
}
