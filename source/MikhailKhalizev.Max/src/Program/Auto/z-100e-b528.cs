using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c68b0fb8-d750-48d6-ad44-4427cf5ee450")]
        public void Method_100e_b528()
        {
            ii(0x100e_b528, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b52d, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a820); /* call 0x10165d52 */
            ii(0x100e_b532, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b533, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b534, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b535, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b536, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b537, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b539, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_b53f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b542, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_b545, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b548, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100e_b54b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_b54e, 3); sub(eax, memd_a32[ds, edx + 0x4]);      /* sub eax, [edx+0x4] */
            ii(0x100e_b551, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_b553, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b556, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100e_b559, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_b55c, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_b55f, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_b561, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b564, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x100e_b567, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b56a, 2); add(edx, memd_a32[ds, eax]);            /* add edx, [eax] */
            ii(0x100e_b56c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b56f, 2); sub(edx, memd_a32[ds, eax]);            /* sub edx, [eax] */
            ii(0x100e_b571, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b574, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100e_b576, 3); mov(memd_a32[ds, eax + 0x16], edx);     /* mov [eax+0x16], edx */
            ii(0x100e_b579, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b57c, 4); mov(dx, memw_a32[ds, eax + 0x10]);      /* mov dx, [eax+0x10] */
            ii(0x100e_b580, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b583, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x100e_b587, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b589, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b58a, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b58b, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b58c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b58d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b58e, 1); retd(); return;                         /* ret */
        }
    }
}
