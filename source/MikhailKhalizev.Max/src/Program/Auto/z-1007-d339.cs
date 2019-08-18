using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d339-ab69d0c3")]
        public void Method_1007_d339()
        {
            ii(0x1007_d339, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_d33e, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8a0f); /* call 0x10165d52 */
            ii(0x1007_d343, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_d344, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_d345, 1); pushd(esi);                             /* push esi */
            ii(0x1007_d346, 1); pushd(edi);                             /* push edi */
            ii(0x1007_d347, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_d348, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d34a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_d350, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_d353, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_d356, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_d359, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d35c, 5); calld(0x1007_62cc, -0x7095);            /* call 0x100762cc */
            ii(0x1007_d361, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_d363, 2); if(jnzd(0x1007_d36b, 0x6)) goto l_0x1007_d36b; /* jnz 0x1007d36b */
            ii(0x1007_d365, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_d369, 2); jmpd(0x1007_d38b, 0x20); goto l_0x1007_d38b; /* jmp 0x1007d38b */
        l_0x1007_d36b:
            ii(0x1007_d36b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d36e, 5); calld(0x1015_09a6, 0xd_3633);           /* call 0x101509a6 */
            ii(0x1007_d373, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_d375, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d378, 4); sub(memw_a32[ds, eax + 0x12], dx);      /* sub [eax+0x12], dx */
            ii(0x1007_d37c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_d37f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d382, 5); calld(0x1008_aab4, 0xd72d);             /* call 0x1008aab4 */
            ii(0x1007_d387, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1007_d38b:
            ii(0x1007_d38b, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_d38e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d390, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d391, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d392, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d393, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d394, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_d395, 1); retd(); return;                         /* ret */
        }
    }
}
