using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09d52192-82bc-472e-bcf0-23e5121890f9")]
        public void /* sys */ Method_1019_57ce()
        {
            ii(0x1019_57ce, 1); pushd(edx);                             /* push edx */
            ii(0x1019_57cf, 1); pushd(esi);                             /* push esi */
            ii(0x1019_57d0, 1); pushd(edi);                             /* push edi */
            ii(0x1019_57d1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_57d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_57d4, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1019_57da, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1019_57dd, 4); mov(memw_a32[ss, ebp - 0x34], cx);      /* mov [ebp-0x34], cx */
            ii(0x1019_57e1, 3); mov(memd_a32[ss, ebp - 0x38], ebx);     /* mov [ebp-0x38], ebx */
            ii(0x1019_57e4, 7); mov(memd_a32[ss, ebp - 0xc], 0x2c);     /* mov dword [ebp-0xc], 0x2c */
            ii(0x1019_57eb, 7); mov(memd_a32[ss, ebp - 0x10], 0x30);    /* mov dword [ebp-0x10], 0x30 */
            ii(0x1019_57f2, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1019_57f9, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1019_5800, 7); cmp(memd_a32[ss, ebp - 0x20], 0x1000);  /* cmp dword [ebp-0x20], 0x1000 */
            ii(0x1019_5807, 2); if(jbd(0x1019_5812, 0x9)) goto l_0x1019_5812; /* jb 0x10195812 */
            ii(0x1019_5809, 7); cmp(memd_a32[ss, ebp - 0x20], 0x1023);  /* cmp dword [ebp-0x20], 0x1023 */
            ii(0x1019_5810, 2); if(jbed(0x1019_581e, 0xc)) goto l_0x1019_581e; /* jbe 0x1019581e */
        l_0x1019_5812:
            ii(0x1019_5812, 7); mov(memd_a32[ss, ebp - 0x28], 0x6);     /* mov dword [ebp-0x28], 0x6 */
            ii(0x1019_5819, 5); jmpd(0x1019_596c, 0x14e); goto l_0x1019_596c; /* jmp 0x1019596c */
        l_0x1019_581e:
            ii(0x1019_581e, 5); mov(edx, 0x101c_07ca);                  /* mov edx, 0x101c07ca */
            ii(0x1019_5823, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1019_5828, 5); calld(Definitions.sys_strcpy, -0x2f95e); /* call 0x10165ecf */
            ii(0x1019_582d, 5); mov(edx, StringDefinitions.Hmidrv386);  /* mov edx, 0x101b3458 */
            ii(0x1019_5832, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1019_5837, 5); calld(Definitions.sys_strcat, -0x2f90b); /* call 0x10165f31 */
            ii(0x1019_583c, 5); pushd(0x200);                           /* push 0x200 */
            ii(0x1019_5841, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1019_5846, 1); pushd(eax);                             /* push eax */
            ii(0x1019_5847, 5); calld(/* sys */ 0x1017_cf25, -0x18927); /* call 0x1017cf25 */
            ii(0x1019_584c, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_584f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1019_5852, 4); cmp(memd_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp dword [ebp-0x4], 0xffffffff */
            ii(0x1019_5856, 2); if(jnzd(0x1019_5864, 0xc)) goto l_0x1019_5864; /* jnz 0x10195864 */
            ii(0x1019_5858, 7); mov(memd_a32[ss, ebp - 0x28], 0xf);     /* mov dword [ebp-0x28], 0xf */
            ii(0x1019_585f, 5); jmpd(0x1019_596c, 0x108); goto l_0x1019_596c; /* jmp 0x1019596c */
        l_0x1019_5864:
            ii(0x1019_5864, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1019_5867, 5); mov(edx, 0x1020_bc90);                  /* mov edx, 0x1020bc90 */
            ii(0x1019_586c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_586f, 5); calld(/* sys */ 0x1017_d1fa, -0x1867a); /* call 0x1017d1fa */
        l_0x1019_5874:
            ii(0x1019_5874, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1019_5877, 6); cmp(eax, memd_a32[ds, 0x1020_bcb0]);    /* cmp eax, [0x1020bcb0] */
            ii(0x1019_587d, 2); if(jad(0x1019_5885, 0x6)) goto l_0x1019_5885; /* ja 0x10195885 */
            ii(0x1019_587f, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1019_5883, 2); if(jzd(0x1019_588a, 0x5)) goto l_0x1019_588a; /* jz 0x1019588a */
        l_0x1019_5885:
            ii(0x1019_5885, 5); jmpd(0x1019_595d, 0xd3); goto l_0x1019_595d; /* jmp 0x1019595d */
        l_0x1019_588a:
            ii(0x1019_588a, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1019_588d, 5); mov(edx, 0x1020_bc60);                  /* mov edx, 0x1020bc60 */
            ii(0x1019_5892, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_5895, 5); calld(/* sys */ 0x1017_d1fa, -0x186a0); /* call 0x1017d1fa */
            ii(0x1019_589a, 5); mov(eax, memd_a32[ds, 0x1020_bc84]);    /* mov eax, [0x1020bc84] */
            ii(0x1019_589f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1019_58a2, 5); mov(eax, memd_a32[ds, 0x1020_bc88]);    /* mov eax, [0x1020bc88] */
            ii(0x1019_58a7, 3); cmp(eax, memd_a32[ss, ebp - 0x20]);     /* cmp eax, [ebp-0x20] */
            ii(0x1019_58aa, 2); if(jnzd(0x1019_58b5, 0x9)) goto l_0x1019_58b5; /* jnz 0x101958b5 */
            ii(0x1019_58ac, 7); test(memb_a32[ds, 0x1020_bc8d], 0x40);  /* test byte [0x1020bc8d], 0x40 */
            ii(0x1019_58b3, 2); if(jnzd(0x1019_58ba, 0x5)) goto l_0x1019_58ba; /* jnz 0x101958ba */
        l_0x1019_58b5:
            ii(0x1019_58b5, 5); jmpd(0x1019_5945, 0x8b); goto l_0x1019_5945; /* jmp 0x10195945 */
        l_0x1019_58ba:
            ii(0x1019_58ba, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1019_58c1, 7); add(memd_a32[ss, ebp - 0x8], 0x4000);   /* add dword [ebp-0x8], 0x4000 */
            ii(0x1019_58c8, 3); pushd(memd_a32[ss, ebp + 0x1c]);        /* push dword [ebp+0x1c] */
            ii(0x1019_58cb, 3); pushd(memd_a32[ss, ebp - 0x8]);         /* push dword [ebp-0x8] */
            ii(0x1019_58ce, 5); calld(/* sys */ 0x1019_4cb7, -0xc1c);   /* call 0x10194cb7 */
            ii(0x1019_58d3, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_58d5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_58d7, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_58da, 4); mov(memw_a32[ss, ebp - 0x2c], bx);      /* mov [ebp-0x2c], bx */
            ii(0x1019_58de, 3); mov(memd_a32[ss, ebp - 0x30], ecx);     /* mov [ebp-0x30], ecx */
            ii(0x1019_58e1, 4); movzx(eax, memw_a32[ss, ebp - 0x2c]);   /* movzx eax, word [ebp-0x2c] */
            ii(0x1019_58e5, 1); pushd(eax);                             /* push eax */
            ii(0x1019_58e6, 3); pushd(memd_a32[ss, ebp - 0x30]);        /* push dword [ebp-0x30] */
            ii(0x1019_58e9, 5); calld(/* sys */ 0x1019_4d7e, -0xb70);   /* call 0x10194d7e */
            ii(0x1019_58ee, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_58f0, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_58f2, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_58f5, 4); mov(memw_a32[ss, ebp - 0x3c], bx);      /* mov [ebp-0x3c], bx */
            ii(0x1019_58f9, 3); mov(memd_a32[ss, ebp - 0x40], ecx);     /* mov [ebp-0x40], ecx */
            ii(0x1019_58fc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1019_58ff, 1); pushd(eax);                             /* push eax */
            ii(0x1019_5900, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x1019_5903, 3); mov(ebx, memd_a32[ss, ebp - 0x2c]);     /* mov ebx, [ebp-0x2c] */
            ii(0x1019_5906, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x1019_5909, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_590c, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1019_590e, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_5910, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_5912, 5); calld(/* sys */ 0x1017_9414, -0x1c503); /* call 0x10179414 */
            ii(0x1019_5917, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1019_591a, 4); lgs(edx, ss, ebp - 0x38);               /* lgs edx, [ebp-0x38] */
            ii(0x1019_591e, 5); mov(memw_a32[gs, edx + 0x4], ax);       /* mov [gs:edx+0x4], ax */
            ii(0x1019_5923, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1019_5926, 4); lgs(edx, ss, ebp - 0x38);               /* lgs edx, [ebp-0x38] */
            ii(0x1019_592a, 3); mov(memd_a32[gs, edx], eax);            /* mov [gs:edx], eax */
            ii(0x1019_592d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1019_5930, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1019_5934, 5); mov(memw_a32[gs, edx + 0x4], ax);       /* mov [gs:edx+0x4], ax */
            ii(0x1019_5939, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1019_593c, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1019_5940, 3); mov(memd_a32[gs, edx], eax);            /* mov [gs:edx], eax */
            ii(0x1019_5943, 2); jmpd(0x1019_5955, 0x10); goto l_0x1019_5955; /* jmp 0x10195955 */
        l_0x1019_5945:
            ii(0x1019_5945, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1019_594a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1019_594d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_5950, 5); calld(Definitions.sys_lseek, -0x187be); /* call 0x1017d197 */
        l_0x1019_5955:
            ii(0x1019_5955, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1019_5958, 5); jmpd(0x1019_5874, -0xe9); goto l_0x1019_5874; /* jmp 0x10195874 */
        l_0x1019_595d:
            ii(0x1019_595d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_5960, 5); calld(/* sys */ 0x1017_d1da, -0x1878b); /* call 0x1017d1da */
            ii(0x1019_5965, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
        l_0x1019_596c:
            ii(0x1019_596c, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1019_596f, 1); leaved();                               /* leave */
            ii(0x1019_5970, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5971, 1); popd(esi);                              /* pop esi */
            ii(0x1019_5972, 1); popd(edx);                              /* pop edx */
            ii(0x1019_5973, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
