using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d9702ab-bc6d-4083-b888-a892742b4a14")]
        public void /* sys */ Method_1017_df7d()
        {
            ii(0x1017_df7d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_df7e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_df7f, 1); pushd(esi);                             /* push esi */
            ii(0x1017_df80, 1); pushd(edi);                             /* push edi */
            ii(0x1017_df81, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_df82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_df84, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1017_df8a, 4); mov(memw_a32[ss, ebp - 0x10], dx);      /* mov [ebp-0x10], dx */
            ii(0x1017_df8e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1017_df91, 7); cmp(memd_a32[ds, 0x101b_e4e8], 0);      /* cmp dword [0x101be4e8], 0x0 */
            ii(0x1017_df98, 2); if(jzd(0x1017_dfa6, 0xc)) goto l_0x1017_dfa6; /* jz 0x1017dfa6 */
            ii(0x1017_df9a, 7); mov(memd_a32[ss, ebp - 0xc], 0x3);      /* mov dword [ebp-0xc], 0x3 */
            ii(0x1017_dfa1, 5); jmpd(0x1017_e0a2, 0xfc); goto l_0x1017_e0a2; /* jmp 0x1017e0a2 */
        l_0x1017_dfa6:
            ii(0x1017_dfa6, 7); mov(memd_a32[ss, ebp - 0x8], 0x2c);     /* mov dword [ebp-0x8], 0x2c */
            ii(0x1017_dfad, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1017_dfb1, 2); if(jnzd(0x1017_dfba, 0x7)) goto l_0x1017_dfba; /* jnz 0x1017dfba */
            ii(0x1017_dfb3, 5); cmp(memw_a32[ss, ebp - 0x10], 0);       /* cmp word [ebp-0x10], 0x0 */
            ii(0x1017_dfb8, 2); if(jzd(0x1017_dfd8, 0x1e)) goto l_0x1017_dfd8; /* jz 0x1017dfd8 */
        l_0x1017_dfba:
            ii(0x1017_dfba, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1017_dfbd, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1017_dfc2, 5); calld(Definitions.sys_strcpy, -0x180f8); /* call 0x10165ecf */
            ii(0x1017_dfc7, 5); mov(edx, 0x101b_30dc);                  /* mov edx, 0x101b30dc */ /* "hmidet.386" */
            ii(0x1017_dfcc, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1017_dfd1, 5); calld(Definitions.sys_strcat, -0x180a5); /* call 0x10165f31 */
            ii(0x1017_dfd6, 2); jmpd(0x1017_dfe7, 0xf); goto l_0x1017_dfe7; /* jmp 0x1017dfe7 */
        l_0x1017_dfd8:
            ii(0x1017_dfd8, 5); mov(edx, 0x101b_30dc);                  /* mov edx, 0x101b30dc */ /* "hmidet.386" */
            ii(0x1017_dfdd, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1017_dfe2, 5); calld(Definitions.sys_strcpy, -0x18118); /* call 0x10165ecf */
        l_0x1017_dfe7:
            ii(0x1017_dfe7, 5); pushd(0x200);                           /* push 0x200 */
            ii(0x1017_dfec, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1017_dff1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_dff2, 5); calld(/* sys */ 0x1017_cf25, -0x10d2);  /* call 0x1017cf25 */
            ii(0x1017_dff7, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1017_dffa, 5); mov(memd_a32[ds, 0x1020_a13c], eax);    /* mov [0x1020a13c], eax */
            ii(0x1017_dfff, 7); cmp(memd_a32[ds, 0x1020_a13c], -0x1 /* 0xff */); /* cmp dword [0x1020a13c], 0xffffffff */
            ii(0x1017_e006, 2); if(jnzd(0x1017_e014, 0xc)) goto l_0x1017_e014; /* jnz 0x1017e014 */
            ii(0x1017_e008, 7); mov(memd_a32[ss, ebp - 0xc], 0xf);      /* mov dword [ebp-0xc], 0xf */
            ii(0x1017_e00f, 5); jmpd(0x1017_e0a2, 0x8e); goto l_0x1017_e0a2; /* jmp 0x1017e0a2 */
        l_0x1017_e014:
            ii(0x1017_e014, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1017_e017, 5); mov(edx, 0x1020_a10c);                  /* mov edx, 0x1020a10c */
            ii(0x1017_e01c, 5); mov(eax, memd_a32[ds, 0x1020_a13c]);    /* mov eax, [0x1020a13c] */
            ii(0x1017_e021, 5); calld(/* sys */ 0x1017_d1fa, -0xe2c);   /* call 0x1017d1fa */
            ii(0x1017_e026, 5); mov(eax, memd_a32[ds, 0x1020_a134]);    /* mov eax, [0x1020a134] */
            ii(0x1017_e02b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1017_e02e, 5); mov(eax, 0x1020_a1ac);                  /* mov eax, 0x1020a1ac */
            ii(0x1017_e033, 1); pushd(eax);                             /* push eax */
            ii(0x1017_e034, 5); pushd(0x1000);                          /* push 0x1000 */
            ii(0x1017_e039, 5); calld(/* sys */ 0x1019_4cb7, 0x16c79);  /* call 0x10194cb7 */
            ii(0x1017_e03e, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_e040, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_e042, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1017_e045, 7); mov(memw_a32[ds, 0x1020_a1ba], bx);     /* mov [0x1020a1ba], bx */
            ii(0x1017_e04c, 6); mov(memd_a32[ds, 0x1020_a1b6], ecx);    /* mov [0x1020a1b6], ecx */
            ii(0x1017_e052, 7); movzx(eax, memw_a32[ds, 0x1020_a1ba]);  /* movzx eax, word [0x1020a1ba] */
            ii(0x1017_e059, 1); pushd(eax);                             /* push eax */
            ii(0x1017_e05a, 6); pushd(memd_a32[ds, 0x1020_a1b6]);       /* push dword [0x1020a1b6] */
            ii(0x1017_e060, 5); calld(/* sys */ 0x1019_4d7e, 0x16d19);  /* call 0x10194d7e */
            ii(0x1017_e065, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_e067, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_e069, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1017_e06c, 7); mov(memw_a32[ds, 0x1020_a1c0], bx);     /* mov [0x1020a1c0], bx */
            ii(0x1017_e073, 6); mov(memd_a32[ds, 0x1020_a1bc], ecx);    /* mov [0x1020a1bc], ecx */
            ii(0x1017_e079, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_e07b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_e07d, 5); mov(eax, memd_a32[ds, 0x1020_a13c]);    /* mov eax, [0x1020a13c] */
            ii(0x1017_e082, 5); calld(Definitions.sys_lseek, -0xef0);   /* call 0x1017d197 */
            ii(0x1017_e087, 10); mov(memd_a32[ds, 0x101b_e4ec], 0);     /* mov dword [0x101be4ec], 0x0 */
            ii(0x1017_e091, 10); mov(memd_a32[ds, 0x101b_e4e8], 0x1);   /* mov dword [0x101be4e8], 0x1 */
            ii(0x1017_e09b, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1017_e0a2:
            ii(0x1017_e0a2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1017_e0a5, 1); leaved();                               /* leave */
            ii(0x1017_e0a6, 1); popd(edi);                              /* pop edi */
            ii(0x1017_e0a7, 1); popd(esi);                              /* pop esi */
            ii(0x1017_e0a8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_e0a9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_e0aa, 1); retd(); return;                         /* ret */
        }
    }
}
