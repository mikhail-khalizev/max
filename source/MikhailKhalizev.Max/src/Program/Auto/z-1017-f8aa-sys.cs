using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_f8aa-fc00c3f2")]
        public void /* sys */ Method_1017_f8aa()
        {
            ii(0x1017_f8aa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_f8ab, 1); pushd(esi);                             /* push esi */
            ii(0x1017_f8ac, 1); pushd(edi);                             /* push edi */
            ii(0x1017_f8ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_f8ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_f8b0, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1017_f8b6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1017_f8b9, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1017_f8bc, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1017_f8bf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_f8c2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f8c5, 7); cmp(memd_a32[ds, eax + 0x101c_02b0], 0); /* cmp dword [eax+0x101c02b0], 0x0 */
            ii(0x1017_f8cc, 2); if(jnzd(0x1017_f8da, 0xc)) goto l_0x1017_f8da; /* jnz 0x1017f8da */
            ii(0x1017_f8ce, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x1017_f8d5, 5); jmpd(0x1017_faba, 0x1e0); goto l_0x1017_faba; /* jmp 0x1017faba */
        l_0x1017_f8da:
            ii(0x1017_f8da, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_f8dd, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f8e0, 10); mov(memd_a32[ds, eax + 0x101c_02d8], 0); /* mov dword [eax+0x101c02d8], 0x0 */
            ii(0x1017_f8ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_f8ed, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f8f0, 10); cmp(memd_a32[ds, eax + 0x101c_035a], 0xe106); /* cmp dword [eax+0x101c035a], 0xe106 */
            ii(0x1017_f8fa, 6); if(jaed(0x1017_f997, 0x97)) goto l_0x1017_f997; /* jae 0x1017f997 */
            ii(0x1017_f900, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_f903, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f906, 7); cmp(memd_a32[ds, eax + 0x101b_e544], 0); /* cmp dword [eax+0x101be544], 0x0 */
            ii(0x1017_f90d, 2); if(jzd(0x1017_f915, 0x6)) goto l_0x1017_f915; /* jz 0x1017f915 */
            ii(0x1017_f90f, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1017_f913, 2); if(jnzd(0x1017_f91a, 0x5)) goto l_0x1017_f91a; /* jnz 0x1017f91a */
        l_0x1017_f915:
            ii(0x1017_f915, 5); jmpd(0x1017_f997, 0x7d); goto l_0x1017_f997; /* jmp 0x1017f997 */
        l_0x1017_f91a:
            ii(0x1017_f91a, 4); imul(edx, memd_a32[ss, ebp - 0x10], 0x6); /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1017_f91e, 7); mov(ax, memw_a32[ds, edx + 0x101c_0318]); /* mov ax, [edx+0x101c0318] */
            ii(0x1017_f925, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1017_f929, 6); mov(eax, memd_a32[ds, edx + 0x101c_0314]); /* mov eax, [edx+0x101c0314] */
            ii(0x1017_f92f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1017_f932, 5); calld(/* sys */ 0x1019_52c7, 0x1_5990); /* call 0x101952c7 */
            ii(0x1017_f937, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_f93c, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1017_f93f, 2); if(jnzd(0x1017_f971, 0x30)) goto l_0x1017_f971; /* jnz 0x1017f971 */
            ii(0x1017_f941, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1017_f944, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1017_f947, 6); mov(ecx, memd_a32[ds, ebx + 0x101c_0332]); /* mov ecx, [ebx+0x101c0332] */
            ii(0x1017_f94d, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1017_f950, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1017_f953, 6); mov(esi, memd_a32[ds, ebx + 0x101c_0346]); /* mov esi, [ebx+0x101c0346] */
            ii(0x1017_f959, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1017_f95c, 3); mov(ebx, memd_a32[ss, ebp - 0x20]);     /* mov ebx, [ebp-0x20] */
            ii(0x1017_f95f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_f961, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_f963, 3); movzx(eax, dx);                         /* movzx eax, dx */
            ii(0x1017_f966, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_f968, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_f96a, 5); calld(/* sys */ 0x1017_fcb7, 0x348);    /* call 0x1017fcb7 */
            ii(0x1017_f96f, 2); jmpd(0x1017_f987, 0x16); goto l_0x1017_f987; /* jmp 0x1017f987 */
        l_0x1017_f971:
            ii(0x1017_f971, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1017_f974, 3); mov(ebx, memd_a32[ss, ebp - 0x20]);     /* mov ebx, [ebp-0x20] */
            ii(0x1017_f977, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_f979, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_f97b, 3); movzx(ebx, dx);                         /* movzx ebx, dx */
            ii(0x1017_f97e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_f97f, 5); calld(/* sys */ 0x1019_4e3d, 0x1_54b9); /* call 0x10194e3d */
            ii(0x1017_f984, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1017_f987:
            ii(0x1017_f987, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_f98a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f98d, 10); mov(memd_a32[ds, eax + 0x101b_e544], 0); /* mov dword [eax+0x101be544], 0x0 */
        l_0x1017_f997:
            ii(0x1017_f997, 4); imul(edx, memd_a32[ss, ebp - 0x10], 0x6); /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1017_f99b, 7); mov(ax, memw_a32[ds, edx + 0x101c_0214]); /* mov ax, [edx+0x101c0214] */
            ii(0x1017_f9a2, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x1017_f9a6, 6); mov(eax, memd_a32[ds, edx + 0x101c_0210]); /* mov eax, [edx+0x101c0210] */
            ii(0x1017_f9ac, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1017_f9af, 4); imul(edx, memd_a32[ss, ebp - 0x10], 0x6); /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1017_f9b3, 7); mov(ax, memw_a32[ds, edx + 0x101c_0232]); /* mov ax, [edx+0x101c0232] */
            ii(0x1017_f9ba, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1017_f9be, 6); mov(eax, memd_a32[ds, edx + 0x101c_022e]); /* mov eax, [edx+0x101c022e] */
            ii(0x1017_f9c4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1017_f9c7, 4); movzx(eax, memw_a32[ss, ebp - 0x24]);   /* movzx eax, word [ebp-0x24] */
            ii(0x1017_f9cb, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f9cc, 3); pushd(memd_a32[ss, ebp - 0x28]);        /* push dword [ebp-0x28] */
            ii(0x1017_f9cf, 4); movzx(eax, memw_a32[ss, ebp - 0x14]);   /* movzx eax, word [ebp-0x14] */
            ii(0x1017_f9d3, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f9d4, 3); pushd(memd_a32[ss, ebp - 0x18]);        /* push dword [ebp-0x18] */
            ii(0x1017_f9d7, 5); calld(/* sys */ 0x1019_4eeb, 0x1_550f); /* call 0x10194eeb */
            ii(0x1017_f9dc, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_f9df, 4); movzx(eax, memw_a32[ss, ebp - 0x24]);   /* movzx eax, word [ebp-0x24] */
            ii(0x1017_f9e3, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f9e4, 3); pushd(memd_a32[ss, ebp - 0x28]);        /* push dword [ebp-0x28] */
            ii(0x1017_f9e7, 4); movzx(eax, memw_a32[ss, ebp - 0x14]);   /* movzx eax, word [ebp-0x14] */
            ii(0x1017_f9eb, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f9ec, 3); pushd(memd_a32[ss, ebp - 0x18]);        /* push dword [ebp-0x18] */
            ii(0x1017_f9ef, 5); calld(/* sys */ 0x1019_4ff3, 0x1_55ff); /* call 0x10194ff3 */
            ii(0x1017_f9f4, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_f9f7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_f9fa, 7); movzx(eax, memb_a32[ds, eax + 0x101c_068c]); /* movzx eax, byte [eax+0x101c068c] */
            ii(0x1017_fa01, 1); pushd(eax);                             /* push eax */
            ii(0x1017_fa02, 5); calld(/* sys */ 0x1019_5173, 0x1_576c); /* call 0x10195173 */
            ii(0x1017_fa07, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_fa0a, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1017_fa0e, 2); if(jzd(0x1017_fa20, 0x10)) goto l_0x1017_fa20; /* jz 0x1017fa20 */
            ii(0x1017_fa10, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_fa13, 5); calld(/* sys */ 0x1019_5726, 0x1_5d0e); /* call 0x10195726 */
            ii(0x1017_fa18, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_fa1b, 5); calld(/* sys */ 0x1019_5976, 0x1_5f56); /* call 0x10195976 */
        l_0x1017_fa20:
            ii(0x1017_fa20, 4); imul(eax, memd_a32[ss, ebp - 0x10], 0x6); /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1017_fa24, 9); mov(memw_a32[ds, eax + 0x101c_0214], 0); /* mov word [eax+0x101c0214], 0x0 */
            ii(0x1017_fa2d, 10); mov(memd_a32[ds, eax + 0x101c_0210], 0); /* mov dword [eax+0x101c0210], 0x0 */
            ii(0x1017_fa37, 4); imul(eax, memd_a32[ss, ebp - 0x10], 0x6); /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1017_fa3b, 9); mov(memw_a32[ds, eax + 0x101c_0232], 0); /* mov word [eax+0x101c0232], 0x0 */
            ii(0x1017_fa44, 10); mov(memd_a32[ds, eax + 0x101c_022e], 0); /* mov dword [eax+0x101c022e], 0x0 */
            ii(0x1017_fa4e, 4); imul(eax, memd_a32[ss, ebp - 0x10], 0x6); /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1017_fa52, 9); mov(memw_a32[ds, eax + 0x101c_0372], 0); /* mov word [eax+0x101c0372], 0x0 */
            ii(0x1017_fa5b, 10); mov(memd_a32[ds, eax + 0x101c_036e], 0); /* mov dword [eax+0x101c036e], 0x0 */
            ii(0x1017_fa65, 4); imul(eax, memd_a32[ss, ebp - 0x10], 0x6); /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1017_fa69, 9); mov(memw_a32[ds, eax + 0x101c_0250], 0); /* mov word [eax+0x101c0250], 0x0 */
            ii(0x1017_fa72, 10); mov(memd_a32[ds, eax + 0x101c_024c], 0); /* mov dword [eax+0x101c024c], 0x0 */
            ii(0x1017_fa7c, 4); imul(eax, memd_a32[ss, ebp - 0x10], 0x6); /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1017_fa80, 9); mov(memw_a32[ds, eax + 0x101c_026e], 0); /* mov word [eax+0x101c026e], 0x0 */
            ii(0x1017_fa89, 10); mov(memd_a32[ds, eax + 0x101c_026a], 0); /* mov dword [eax+0x101c026a], 0x0 */
            ii(0x1017_fa93, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_fa96, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_fa99, 10); mov(memd_a32[ds, eax + 0x101c_03cc], 0); /* mov dword [eax+0x101c03cc], 0x0 */
            ii(0x1017_faa3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_faa6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_faa9, 10); mov(memd_a32[ds, eax + 0x101c_02b0], 0); /* mov dword [eax+0x101c02b0], 0x0 */
            ii(0x1017_fab3, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1017_faba:
            ii(0x1017_faba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_fabd, 1); leaved();                               /* leave */
            ii(0x1017_fabe, 1); popd(edi);                              /* pop edi */
            ii(0x1017_fabf, 1); popd(esi);                              /* pop esi */
            ii(0x1017_fac0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_fac1, 1); retd();                                 /* ret */
        }
    }
}
