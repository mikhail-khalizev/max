using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b6c3-39724005")]
        public void Method_1011_b6c3()
        {
            ii(0x1011_b6c3, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_b6c8, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a685); /* call 0x10165d52 */
            ii(0x1011_b6cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_b6ce, 1); pushd(esi);                             /* push esi */
            ii(0x1011_b6cf, 1); pushd(edi);                             /* push edi */
            ii(0x1011_b6d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_b6d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b6d3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_b6d9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_b6dc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_b6df, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_b6e2, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_b6e9, 2); jmpd(0x1011_b6f1, 0x6); goto l_0x1011_b6f1; /* jmp 0x1011b6f1 */
        l_0x1011_b6eb:
            ii(0x1011_b6eb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_b6ee, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1011_b6f1:
            ii(0x1011_b6f1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_b6f4, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1011_b6f8, 2); if(jged(0x1011_b712, 0x18)) goto l_0x1011_b712; /* jge 0x1011b712 */
            ii(0x1011_b6fa, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_b6fe, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_b700, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_b703, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_b705, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_b708, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b70b, 5); calld(0x1012_0b08, 0x53f8);             /* call 0x10120b08 */
            ii(0x1011_b710, 2); jmpd(0x1011_b6eb, -0x27); goto l_0x1011_b6eb; /* jmp 0x1011b6eb */
        l_0x1011_b712:
            ii(0x1011_b712, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b714, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_b715, 1); popd(edi);                              /* pop edi */
            ii(0x1011_b716, 1); popd(esi);                              /* pop esi */
            ii(0x1011_b717, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_b718, 1); retd(); return;                         /* ret */
        }
    }
}
