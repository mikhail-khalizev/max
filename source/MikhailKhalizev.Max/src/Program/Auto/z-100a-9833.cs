using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8159396c-572b-4d0b-9835-daf77f335dfc")]
        public void Method_100a_9833()
        {
            ii(0x100a_9833, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_9838, 5); calld(Definitions.sys_check_available_stack_size, 0xb_c515); /* call 0x10165d52 */
            ii(0x100a_983d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_983e, 1); pushd(esi);                             /* push esi */
            ii(0x100a_983f, 1); pushd(edi);                             /* push edi */
            ii(0x100a_9840, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_9841, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9843, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_9849, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_984c, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_984f, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_9852, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9855, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_2d6a); /* call 0x10076af0 */
            ii(0x100a_985a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_985d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9860, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_9863, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_2d78); /* call 0x10076af0 */
            ii(0x100a_9868, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100a_986b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_986e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9871, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x100a_9874, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_2d89); /* call 0x10076af0 */
            ii(0x100a_9879, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x100a_987c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_987f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_9882, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9885, 5); calld(0x1008_8b44, -0x2_0d46);          /* call 0x10088b44 */
            ii(0x100a_988a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_988d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_9890, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x100a_9894, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9897, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x100a_989b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_989e, 3); imul(edx, edx);                         /* imul edx, edx */
            ii(0x100a_98a1, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x100a_98a5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_98a8, 5); calld(0x100a_98bd, 0x10);               /* call 0x100a98bd */
            ii(0x100a_98ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_98b0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_98b3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_98b6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_98b8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_98b9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_98ba, 1); popd(esi);                              /* pop esi */
            ii(0x100a_98bb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_98bc, 1); retd(); return;                         /* ret */
        }
    }
}
