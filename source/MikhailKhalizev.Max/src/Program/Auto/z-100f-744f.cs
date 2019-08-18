using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_744f-58ed0d5d")]
        public void Method_100f_744f()
        {
            ii(0x100f_744f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_7454, 5); calld(Definitions.sys_check_available_stack_size, 0x6_e8f9); /* call 0x10165d52 */
            ii(0x100f_7459, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_745a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_745b, 1); pushd(esi);                             /* push esi */
            ii(0x100f_745c, 1); pushd(edi);                             /* push edi */
            ii(0x100f_745d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_745e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7460, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_7466, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_7469, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100f_746c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_7471, 5); calld(0x1007_6338, -0x8_113e);          /* call 0x10076338 */
            ii(0x100f_7476, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100f_7479, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_747b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_747d, 5); calld(0x1007_64b8, -0x8_0fca);          /* call 0x100764b8 */
            ii(0x100f_7482, 2); jmpd(0x100f_748c, 0x8); goto l_0x100f_748c; /* jmp 0x100f748c */
        l_0x100f_7484:
            ii(0x100f_7484, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_7487, 5); calld(0x1007_6bf8, -0x8_0894);          /* call 0x10076bf8 */
        l_0x100f_748c:
            ii(0x100f_748c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_748e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_7491, 5); calld(0x1013_ad71, 0x4_38db);           /* call 0x1013ad71 */
            ii(0x100f_7496, 2); test(al, al);                           /* test al, al */
            ii(0x100f_7498, 2); if(jzd(0x100f_74e3, 0x49)) goto l_0x100f_74e3; /* jz 0x100f74e3 */
            ii(0x100f_749a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_749d, 5); calld(0x1007_63a0, -0x8_1102);          /* call 0x100763a0 */
            ii(0x100f_74a2, 5); calld(0x1007_6204, -0x8_12a3);          /* call 0x10076204 */
            ii(0x100f_74a7, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_74aa, 2); if(jnzd(0x100f_74c8, 0x1c)) goto l_0x100f_74c8; /* jnz 0x100f74c8 */
            ii(0x100f_74ac, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_74af, 5); calld(0x1007_63a0, -0x8_1114);          /* call 0x100763a0 */
            ii(0x100f_74b4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_74b7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_74ba, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_74bd, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x100f_74c3, 3); cmp(al, memb_a32[ss, ebp - 0x4]);       /* cmp al, [ebp-0x4] */
            ii(0x100f_74c6, 2); if(jzd(0x100f_74ca, 0x2)) goto l_0x100f_74ca; /* jz 0x100f74ca */
        l_0x100f_74c8:
            ii(0x100f_74c8, 2); jmpd(0x100f_74e1, 0x17); goto l_0x100f_74e1; /* jmp 0x100f74e1 */
        l_0x100f_74ca:
            ii(0x100f_74ca, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_74cd, 5); calld(0x1007_63d4, -0x8_10fe);          /* call 0x100763d4 */
            ii(0x100f_74d2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_74d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_74d7, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_74da, 5); calld(0x1007_5f6c, -0x8_1573);          /* call 0x10075f6c */
            ii(0x100f_74df, 2); jmpd(0x100f_7500, 0x1f); goto l_0x100f_7500; /* jmp 0x100f7500 */
        l_0x100f_74e1:
            ii(0x100f_74e1, 2); jmpd(0x100f_7484, -0x5f); goto l_0x100f_7484; /* jmp 0x100f7484 */
        l_0x100f_74e3:
            ii(0x100f_74e3, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_74ea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_74ec, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_74ef, 5); calld(0x1007_5f6c, -0x8_1588);          /* call 0x10075f6c */
            ii(0x100f_74f4, 2); jmpd(0x100f_7500, 0xa); goto l_0x100f_7500; /* jmp 0x100f7500 */
        //    ii(0x100f_74f6, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100f_74f8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //    ii(0x100f_74fb, 5); calld(0x1007_5f6c, -0x8_1594);          /* call 0x10075f6c */
        l_0x100f_7500:
            ii(0x100f_7500, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7503, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7505, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_7506, 1); popd(edi);                              /* pop edi */
            ii(0x100f_7507, 1); popd(esi);                              /* pop esi */
            ii(0x100f_7508, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_7509, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_750a, 1); retd(); return;                         /* ret */
        }
    }
}
