using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89ba582e-bb17-4e21-8de4-1b231361ae21")]
        public void Method_100e_4cb4()
        {
            ii(0x100e_4cb4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_4cb9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_1094); /* call 0x10165d52 */
            ii(0x100e_4cbe, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_4cbf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_4cc0, 1); pushd(edx);                             /* push edx */
            ii(0x100e_4cc1, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4cc2, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4cc3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4cc4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4cc6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_4ccc, 5); mov(eax, 0x101b_7f2c);                  /* mov eax, 0x101b7f2c */
            ii(0x100e_4cd1, 5); calld(/* sys */ 0x1016_611f, 0x8_1449); /* call 0x1016611f */
            ii(0x100e_4cd6, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_4cdb, 5); calld(0x100e_80c8, 0x33e8);             /* call 0x100e80c8 */
            ii(0x100e_4ce0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_4ce3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_4ce6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_4ce9, 10); mov(memd_a32[ds, 0x101b_7f34], 0x1);   /* mov dword [0x101b7f34], 0x1 */
            ii(0x100e_4cf3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4cf5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4cf6, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4cf7, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4cf8, 1); popd(edx);                              /* pop edx */
            ii(0x100e_4cf9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_4cfa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_4cfb, 1); retd(); return;                         /* ret */
        }
    }
}
