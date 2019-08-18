using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_650e-2a345a96")]
        public void Method_100b_650e()
        {
            ii(0x100b_650e, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_6513, 5); calld(Definitions.sys_check_available_stack_size, 0xa_f83a); /* call 0x10165d52 */
            ii(0x100b_6518, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_6519, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_651a, 1); pushd(edx);                             /* push edx */
            ii(0x100b_651b, 1); pushd(esi);                             /* push esi */
            ii(0x100b_651c, 1); pushd(edi);                             /* push edi */
            ii(0x100b_651d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_651e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_6520, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_6526, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_6529, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_652c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_652f, 5); calld(0x1007_6338, -0x4_01fc);          /* call 0x10076338 */
            ii(0x100b_6534, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x100b_6537, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6539, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_653b, 5); calld(0x1007_64b8, -0x4_0088);          /* call 0x100764b8 */
            ii(0x100b_6540, 2); jmpd(0x100b_654a, 0x8); goto l_0x100b_654a; /* jmp 0x100b654a */
        l_0x100b_6542:
            ii(0x100b_6542, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_6545, 5); calld(0x1007_6bf8, -0x3_f952);          /* call 0x10076bf8 */
        l_0x100b_654a:
            ii(0x100b_654a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_654c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_654f, 5); calld(0x1013_ad71, 0x8_481d);           /* call 0x1013ad71 */
            ii(0x100b_6554, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6556, 2); if(jzd(0x100b_6586, 0x2e)) goto l_0x100b_6586; /* jz 0x100b6586 */
            ii(0x100b_6558, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_655b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_655e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_6561, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_6564, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_6567, 5); calld(0x1007_63d4, -0x4_0198);          /* call 0x100763d4 */
            ii(0x100b_656c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_656e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_6571, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
            ii(0x100b_6574, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6576, 2); if(jzd(0x100b_6584, 0xc)) goto l_0x100b_6584; /* jz 0x100b6584 */
            ii(0x100b_6578, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_657a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_657d, 5); calld(0x1007_5f6c, -0x4_0616);          /* call 0x10075f6c */
            ii(0x100b_6582, 2); jmpd(0x100b_6590, 0xc); goto l_0x100b_6590; /* jmp 0x100b6590 */
        l_0x100b_6584:
            ii(0x100b_6584, 2); jmpd(0x100b_6542, -0x44); goto l_0x100b_6542; /* jmp 0x100b6542 */
        l_0x100b_6586:
            ii(0x100b_6586, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6588, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_658b, 5); calld(0x1007_5f6c, -0x4_0624);          /* call 0x10075f6c */
        l_0x100b_6590:
            ii(0x100b_6590, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6592, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_6593, 1); popd(edi);                              /* pop edi */
            ii(0x100b_6594, 1); popd(esi);                              /* pop esi */
            ii(0x100b_6595, 1); popd(edx);                              /* pop edx */
            ii(0x100b_6596, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_6597, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_6598, 1); retd(); return;                         /* ret */
        }
    }
}
