using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d2eaaa01-caf9-45ec-aac8-488ddb550f14")]
        public void Method_1012_e2a7()
        {
            ii(0x1012_e2a7, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_e2ac, 5); calld(Definitions.sys_check_available_stack_size, 0x37aa1); /* call 0x10165d52 */
            ii(0x1012_e2b1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_e2b2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_e2b3, 1); pushd(esi);                             /* push esi */
            ii(0x1012_e2b4, 1); pushd(edi);                             /* push edi */
            ii(0x1012_e2b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_e2b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e2b8, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_e2be, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_e2c1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_e2c4, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_e2cb, 2); jmpd(0x1012_e2d3, 0x6); goto l_0x1012_e2d3; /* jmp 0x1012e2d3 */
        l_0x1012_e2cd:
            ii(0x1012_e2cd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_e2d0, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1012_e2d3:
            ii(0x1012_e2d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e2d6, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e2d9, 5); calld(Definitions.my_1_get_count, -0x82e06); /* call 0x100ab4d8 */
            ii(0x1012_e2de, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1012_e2e2, 2); if(jled(0x1012_e2fd, 0x19)) goto l_0x1012_e2fd; /* jle 0x1012e2fd */
            ii(0x1012_e2e4, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e2e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e2eb, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e2ee, 5); calld(0x1013_18f8, 0x3605);             /* call 0x101318f8 */
            ii(0x1012_e2f3, 5); calld(0x1013_19f4, 0x36fc);             /* call 0x101319f4 */
            ii(0x1012_e2f8, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1012_e2fb, 2); if(jnzd(0x1012_e2cd, -0x30)) goto l_0x1012_e2cd; /* jnz 0x1012e2cd */
        l_0x1012_e2fd:
            ii(0x1012_e2fd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_e300, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_e303, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_e306, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e308, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_e309, 1); popd(edi);                              /* pop edi */
            ii(0x1012_e30a, 1); popd(esi);                              /* pop esi */
            ii(0x1012_e30b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_e30c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_e30d, 1); retd(); return;                         /* ret */
        }
    }
}
