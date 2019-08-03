using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("026d4988-76ea-48b0-b9ed-e2ce055d87b5")]
        public void Method_100e_718a()
        {
            ii(0x100e_718a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_718f, 5); calld(Definitions.sys_check_available_stack_size, 0x7ebbe); /* call 0x10165d52 */
            ii(0x100e_7194, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_7195, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_7196, 1); pushd(esi);                             /* push esi */
            ii(0x100e_7197, 1); pushd(edi);                             /* push edi */
            ii(0x100e_7198, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_7199, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_719b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_71a1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_71a4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_71a7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_71aa, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x100e_71ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_71b0, 5); calld(0x1015_301f, 0x6be6a);            /* call 0x1015301f */
            ii(0x100e_71b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_71b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_71b8, 1); popd(edi);                              /* pop edi */
            ii(0x100e_71b9, 1); popd(esi);                              /* pop esi */
            ii(0x100e_71ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_71bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_71bc, 1); retd(); return;                         /* ret */
        }
    }
}
