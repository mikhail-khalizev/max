using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a8f7-840a3d94")]
        public void Method_1010_a8f7()
        {
            ii(0x1010_a8f7, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_a8fc, 5); calld(Definitions.sys_check_available_stack_size, 0x5_b451); /* call 0x10165d52 */
            ii(0x1010_a901, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_a902, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_a903, 1); pushd(edx);                             /* push edx */
            ii(0x1010_a904, 1); pushd(esi);                             /* push esi */
            ii(0x1010_a905, 1); pushd(edi);                             /* push edi */
            ii(0x1010_a906, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_a907, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a909, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_a90f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_a912, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1010_a917, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a91a, 5); calld(0x1010_a26b, -0x6b4);             /* call 0x1010a26b */
            ii(0x1010_a91f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_a924, 5); mov(edx, 0x101c_4e54);                  /* mov edx, 0x101c4e54 */
            ii(0x1010_a929, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_a92c, 5); calld(0x100d_4d78, -0x3_5bb9);          /* call 0x100d4d78 */
            ii(0x1010_a931, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a933, 5); mov(edx, 0x101b_a6b0);                  /* mov edx, 0x101ba6b0 */
            ii(0x1010_a938, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a93b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a93d, 5); calld(0x1010_a2d7, -0x66b);             /* call 0x1010a2d7 */
            ii(0x1010_a942, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_a947, 5); mov(edx, 0x101c_4e54);                  /* mov edx, 0x101c4e54 */
            ii(0x1010_a94c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1010_a94f, 5); calld(0x100d_4d78, -0x3_5bdc);          /* call 0x100d4d78 */
            ii(0x1010_a954, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a956, 5); mov(edx, 0x101b_a6c4);                  /* mov edx, 0x101ba6c4 */
            ii(0x1010_a95b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a95e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a960, 5); calld(0x1010_a2d7, -0x68e);             /* call 0x1010a2d7 */
            ii(0x1010_a965, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1010_a96a, 5); calld(0x1007_5fdc, -0x9_4993);          /* call 0x10075fdc */
            ii(0x1010_a96f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_a972, 7); mov(memd_a32[ss, ebp - 0x10], 0x7);     /* mov dword [ebp-0x10], 0x7 */
        l_0x1010_a979:
            ii(0x1010_a979, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1010_a97c, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1010_a981, 2); if(jzd(0x1010_a9a0, 0x1d)) goto l_0x1010_a9a0; /* jz 0x1010a9a0 */
            ii(0x1010_a983, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_a987, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1010_a98a, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a98d, 6); mov(eax, memd_a32[ds, eax + 0x101b_a5bc]); /* mov eax, [eax+0x101ba5bc] */
            ii(0x1010_a993, 5); calld(/* sys */ 0x1017_90ce, 0x6_e736); /* call 0x101790ce */
            ii(0x1010_a998, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_a99c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_a99e, 2); if(jld(0x1010_a979, -0x27)) goto l_0x1010_a979; /* jl 0x1010a979 */
        l_0x1010_a9a0:
            ii(0x1010_a9a0, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1010_a9a5, 5); calld(0x1007_5fdc, -0x9_49ce);          /* call 0x10075fdc */
            ii(0x1010_a9aa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_a9ad, 7); mov(memd_a32[ss, ebp - 0xc], 0x7);      /* mov dword [ebp-0xc], 0x7 */
        l_0x1010_a9b4:
            ii(0x1010_a9b4, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_a9b7, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_a9bc, 2); if(jzd(0x1010_a9db, 0x1d)) goto l_0x1010_a9db; /* jz 0x1010a9db */
            ii(0x1010_a9be, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a9c2, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1010_a9c5, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a9c8, 6); mov(eax, memd_a32[ds, eax + 0x101b_a5bc]); /* mov eax, [eax+0x101ba5bc] */
            ii(0x1010_a9ce, 5); calld(/* sys */ 0x1017_90ce, 0x6_e6fb); /* call 0x101790ce */
            ii(0x1010_a9d3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_a9d7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_a9d9, 2); if(jld(0x1010_a9b4, -0x27)) goto l_0x1010_a9b4; /* jl 0x1010a9b4 */
        l_0x1010_a9db:
            ii(0x1010_a9db, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x1010_a9df, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1010_a9e4, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x1010_a9e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a9ec, 5); calld(0x1010_a36e, -0x683);             /* call 0x1010a36e */
            ii(0x1010_a9f1, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1010_a9f5, 5); mov(ebx, 0x16);                         /* mov ebx, 0x16 */
            ii(0x1010_a9fa, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x1010_a9ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_aa02, 5); calld(0x1010_a36e, -0x699);             /* call 0x1010a36e */
            ii(0x1010_aa07, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_aa09, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_aa0a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_aa0b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_aa0c, 1); popd(edx);                              /* pop edx */
            ii(0x1010_aa0d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_aa0e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_aa0f, 1); retd(); return;                         /* ret */
        }
    }
}
