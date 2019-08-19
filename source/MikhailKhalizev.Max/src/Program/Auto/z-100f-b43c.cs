using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_b43c-5941abbe")]
        public void Method_100f_b43c()
        {
            ii(0x100f_b43c, 5); pushd(0x4e8);                           /* push 0x4e8 */
            ii(0x100f_b441, 5); calld(Definitions.sys_check_available_stack_size, 0x6_a90c); /* call 0x10165d52 */
            ii(0x100f_b446, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_b447, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_b448, 1); pushd(edx);                             /* push edx */
            ii(0x100f_b449, 1); pushd(esi);                             /* push esi */
            ii(0x100f_b44a, 1); pushd(edi);                             /* push edi */
            ii(0x100f_b44b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_b44c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_b44e, 6); sub(esp, 0x4c0);                        /* sub esp, 0x4c0 */
            ii(0x100f_b454, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_b457, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100f_b45b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_b45f, 6); lea(eax, ebp - 0x3f0);                  /* lea eax, [ebp-0x3f0] */
            ii(0x100f_b465, 5); calld(0x100d_c9c9, -0x1_eaa1);          /* call 0x100dc9c9 */
            ii(0x100f_b46a, 6); mov(memd_a32[ss, ebp - 0x3f4], eax);    /* mov [ebp-0x3f4], eax */
            ii(0x100f_b470, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100f_b474, 7); cmp(memb_a32[ds, 0x101c_388b], 0);      /* cmp byte [0x101c388b], 0x0 */
            ii(0x100f_b47b, 2); if(jzd(0x100f_b4c1, 0x44)) goto l_0x100f_b4c1; /* jz 0x100fb4c1 */
            ii(0x100f_b47d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b481, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_b484, 6); pushd(memd_a32[ds, eax + 0x101b_b444]); /* push dword [eax+0x101bb444] */
            ii(0x100f_b48a, 5); mov(eax, StringDefinitions.SBeginCargoSelection); /* mov eax, 0x101a2898 */
            ii(0x100f_b48f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_b490, 6); lea(eax, ebp - 0x4bc);                  /* lea eax, [ebp-0x4bc] */
            ii(0x100f_b496, 1); pushd(eax);                             /* push eax */
            ii(0x100f_b497, 5); calld(Definitions.sys_sprintf, 0x6_aa65); /* call 0x10165f01 */
            ii(0x100f_b49c, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_b49f, 5); calld(0x100c_aa00, -0x3_0aa4);          /* call 0x100caa00 */
            ii(0x100f_b4a4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_b4a9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_b4aa, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_b4af, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_b4b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b4b6, 6); lea(eax, ebp - 0x4bc);                  /* lea eax, [ebp-0x4bc] */
            ii(0x100f_b4bc, 5); calld(0x1011_5d23, 0x1_a862);           /* call 0x10115d23 */
        l_0x100f_b4c1:
            ii(0x100f_b4c1, 6); lea(eax, ebp - 0x3f0);                  /* lea eax, [ebp-0x3f0] */
            ii(0x100f_b4c7, 5); calld(0x100d_b229, -0x2_02a3);          /* call 0x100db229 */
            ii(0x100f_b4cc, 6); mov(memd_a32[ss, ebp - 0x4c0], eax);    /* mov [ebp-0x4c0], eax */
            ii(0x100f_b4d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b4d4, 6); lea(eax, ebp - 0x3f0);                  /* lea eax, [ebp-0x3f0] */
            ii(0x100f_b4da, 5); calld(0x100d_e188, -0x1_d357);          /* call 0x100de188 */
            ii(0x100f_b4df, 2); jmpd(0x100f_b4ee, 0xd); goto l_0x100f_b4ee; /* jmp 0x100fb4ee */
        //  ii(0x100f_b4e1, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100f_b4e3, 6); lea(eax, ebp - 0x3f0);                  /* lea eax, [ebp-0x3f0] */
        //  ii(0x100f_b4e9, 5); calld(0x100d_e188, -0x1_d366);          /* call 0x100de188 */
        l_0x100f_b4ee:
            ii(0x100f_b4ee, 6); mov(eax, memd_a32[ss, ebp - 0x4c0]);    /* mov eax, [ebp-0x4c0] */
            ii(0x100f_b4f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_b4f6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_b4f7, 1); popd(edi);                              /* pop edi */
            ii(0x100f_b4f8, 1); popd(esi);                              /* pop esi */
            ii(0x100f_b4f9, 1); popd(edx);                              /* pop edx */
            ii(0x100f_b4fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_b4fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_b4fc, 1); retd(); return;                         /* ret */
        }
    }
}
