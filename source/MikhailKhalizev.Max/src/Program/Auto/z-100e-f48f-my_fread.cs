using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a9ba9add-f331-4207-8d3b-4297b8f27ff5")]
        public void my_fread()
        {
            ii(0x100e_f48f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_f494, 5); calld(Definitions.sys_check_available_stack_size, 0x7_68b9); /* call 0x10165d52 */
            ii(0x100e_f499, 1); pushd(esi);                             /* push esi */
            ii(0x100e_f49a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_f49b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_f49c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f49e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_f4a4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_f4a7, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_f4aa, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_f4ad, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100e_f4b0, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100e_f4b3, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_f4b6, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_f4b9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_f4bc, 5); calld(Definitions.sys_fread, 0x8_30ab); /* call 0x1017256c */
            ii(0x100e_f4c1, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_f4c4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_f4c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f4c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_f4ca, 1); popd(edi);                              /* pop edi */
            ii(0x100e_f4cb, 1); popd(esi);                              /* pop esi */
            ii(0x100e_f4cc, 1); retd(); return;                         /* ret */
        }
    }
}
