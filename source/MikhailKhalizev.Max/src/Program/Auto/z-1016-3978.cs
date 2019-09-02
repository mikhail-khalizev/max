using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3978-52b79bf2")]
        public void Method_1016_3978()
        {
            ii(0x1016_3978, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_397d, 5); call(Definitions.sys_check_available_stack_size, 0x23d0); /* call 0x10165d52 */
            ii(0x1016_3982, 1); push(ebx);                              /* push ebx */
            ii(0x1016_3983, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3984, 1); push(esi);                              /* push esi */
            ii(0x1016_3985, 1); push(edi);                              /* push edi */
            ii(0x1016_3986, 1); push(ebp);                              /* push ebp */
            ii(0x1016_3987, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3989, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1016_398f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_3992, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_3995, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_3998, 3); mov(ebx, memd[ds, ebx + 6]);            /* mov ebx, [ebx+0x6] */
            ii(0x1016_399b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_399e, 5); mov(edx, StringDefinitions.Turns6);     /* mov edx, 0x101b2a93 */
            ii(0x1016_39a3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_39a6, 5); call(0x1014_74f5, -0x1_c4b6);           /* call 0x101474f5 */
            ii(0x1016_39ab, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_39ae, 3); mov(ebx, memd[ds, ebx + 8]);            /* mov ebx, [ebx+0x8] */
            ii(0x1016_39b1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_39b4, 5); mov(edx, StringDefinitions.Hits8);      /* mov edx, 0x101b2a99 */
            ii(0x1016_39b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_39bc, 5); call(0x1014_74f5, -0x1_c4cc);           /* call 0x101474f5 */
            ii(0x1016_39c1, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_39c4, 3); mov(ebx, memd[ds, ebx + 0xa]);          /* mov ebx, [ebx+0xa] */
            ii(0x1016_39c7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_39ca, 5); mov(edx, StringDefinitions.Armor3);     /* mov edx, 0x101b2a9e */
            ii(0x1016_39cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_39d2, 5); call(0x1014_74f5, -0x1_c4e2);           /* call 0x101474f5 */
            ii(0x1016_39d7, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_39da, 3); mov(ebx, memd[ds, ebx + 0xc]);          /* mov ebx, [ebx+0xc] */
            ii(0x1016_39dd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_39e0, 5); mov(edx, StringDefinitions.Attack5);    /* mov edx, 0x101b2aa4 */
            ii(0x1016_39e5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_39e8, 5); call(0x1014_74f5, -0x1_c4f8);           /* call 0x101474f5 */
            ii(0x1016_39ed, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_39f0, 3); mov(ebx, memd[ds, ebx + 0xe]);          /* mov ebx, [ebx+0xe] */
            ii(0x1016_39f3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_39f6, 5); mov(edx, StringDefinitions.Speed7);     /* mov edx, 0x101b2aab */
            ii(0x1016_39fb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_39fe, 5); call(0x1014_74f5, -0x1_c50e);           /* call 0x101474f5 */
            ii(0x1016_3a03, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_3a06, 3); mov(ebx, memd[ds, ebx + 0x10]);         /* mov ebx, [ebx+0x10] */
            ii(0x1016_3a09, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3a0c, 5); mov(edx, StringDefinitions.Range3);     /* mov edx, 0x101b2ab1 */
            ii(0x1016_3a11, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a14, 5); call(0x1014_74f5, -0x1_c524);           /* call 0x101474f5 */
            ii(0x1016_3a19, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_3a1c, 3); mov(ebx, memd[ds, ebx + 0x12]);         /* mov ebx, [ebx+0x12] */
            ii(0x1016_3a1f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3a22, 5); mov(edx, StringDefinitions.Rounds2);    /* mov edx, 0x101b2ab7 */
            ii(0x1016_3a27, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a2a, 5); call(0x1014_74f5, -0x1_c53a);           /* call 0x101474f5 */
            ii(0x1016_3a2f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3a32, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_3a34, 3); mov(bl, memb[ds, eax + 0x16]);          /* mov bl, [eax+0x16] */
            ii(0x1016_3a37, 5); mov(edx, StringDefinitions.MoveAndFire4); /* mov edx, 0x101b2abe */
            ii(0x1016_3a3c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a3f, 5); call(0x1014_777e, -0x1_c2c6);           /* call 0x1014777e */
            ii(0x1016_3a44, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_3a47, 3); mov(ebx, memd[ds, ebx + 0x15]);         /* mov ebx, [ebx+0x15] */
            ii(0x1016_3a4a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3a4d, 5); mov(edx, StringDefinitions.Scan3);      /* mov edx, 0x101b2acc */
            ii(0x1016_3a52, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a55, 5); call(0x1014_74f5, -0x1_c565);           /* call 0x101474f5 */
            ii(0x1016_3a5a, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1016_3a5d, 3); mov(ebx, memd[ds, ebx + 0x17]);         /* mov ebx, [ebx+0x17] */
            ii(0x1016_3a60, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3a63, 5); mov(edx, StringDefinitions.Storage4);   /* mov edx, 0x101b2ad1 */
            ii(0x1016_3a68, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a6b, 5); call(0x1014_74f5, -0x1_c57b);           /* call 0x101474f5 */
            ii(0x1016_3a70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3a73, 3); mov(ebx, memd[ds, eax + 0x19]);         /* mov ebx, [eax+0x19] */
            ii(0x1016_3a76, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3a79, 5); mov(edx, StringDefinitions.Ammo8);      /* mov edx, 0x101b2ad9 */
            ii(0x1016_3a7e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a81, 5); call(0x1014_74f5, -0x1_c591);           /* call 0x101474f5 */
            ii(0x1016_3a86, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3a89, 3); mov(ebx, memd[ds, eax + 0x1b]);         /* mov ebx, [eax+0x1b] */
            ii(0x1016_3a8c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3a8f, 5); mov(edx, StringDefinitions.AttackRadius2); /* mov edx, 0x101b2ade */
            ii(0x1016_3a94, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3a97, 5); call(0x1014_74f5, -0x1_c5a7);           /* call 0x101474f5 */
            ii(0x1016_3a9c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3a9f, 3); mov(ebx, memd[ds, eax + 0x1d]);         /* mov ebx, [eax+0x1d] */
            ii(0x1016_3aa2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3aa5, 5); mov(edx, StringDefinitions.AgentAdjust2); /* mov edx, 0x101b2aec */
            ii(0x1016_3aaa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3aad, 5); call(0x1014_74f5, -0x1_c5bd);           /* call 0x101474f5 */
            ii(0x1016_3ab2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3ab5, 3); mov(ebx, memd[ds, eax + 0x1f]);         /* mov ebx, [eax+0x1f] */
            ii(0x1016_3ab8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_3abb, 5); mov(edx, StringDefinitions.Version2);   /* mov edx, 0x101b2af9 */
            ii(0x1016_3ac0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3ac3, 5); call(0x1014_74f5, -0x1_c5d3);           /* call 0x101474f5 */
            ii(0x1016_3ac8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_3acb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_3acd, 3); mov(bl, memb[ds, eax + 0x23]);          /* mov bl, [eax+0x23] */
            ii(0x1016_3ad0, 5); mov(edx, StringDefinitions.UnitsBuilt3); /* mov edx, 0x101b2b01 */
            ii(0x1016_3ad5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_3ad8, 5); call(0x1014_74f5, -0x1_c5e8);           /* call 0x101474f5 */
            ii(0x1016_3add, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3adf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_3ae0, 1); pop(edi);                               /* pop edi */
            ii(0x1016_3ae1, 1); pop(esi);                               /* pop esi */
            ii(0x1016_3ae2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_3ae3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_3ae4, 1); ret();                                  /* ret */
        }
    }
}
