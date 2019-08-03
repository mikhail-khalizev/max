using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f23bf910-13bd-4c95-8a3e-de05c176c75e")]
        public void Method_100c_79a0()
        {
            ii(0x100c_79a0, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100c_79a5, 5); calld(Definitions.sys_check_available_stack_size, 0x9e3a8); /* call 0x10165d52 */
            ii(0x100c_79aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_79ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_79ac, 1); pushd(edx);                             /* push edx */
            ii(0x100c_79ad, 1); pushd(esi);                             /* push esi */
            ii(0x100c_79ae, 1); pushd(edi);                             /* push edi */
            ii(0x100c_79af, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_79b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_79b2, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_79b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_79bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_79be, 5); cmp(memw_a32[ds, eax + 0xa], -0x1 /* 0xff */); /* cmp word [eax+0xa], 0xffff */
            ii(0x100c_79c3, 6); if(jzd(0x100c_7ae2, 0x119)) goto l_0x100c_7ae2; /* jz 0x100c7ae2 */
            ii(0x100c_79c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_79cc, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100c_79cf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_79d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_79d5, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_79d8, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x100c_79de, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100c_79e3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_79e5, 5); calld(0x100d_fd2c, 0x18342);            /* call 0x100dfd2c */
            ii(0x100c_79ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_79ec, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_79ef, 5); calld(0x1007_6800, -0x511f4);           /* call 0x10076800 */
            ii(0x100c_79f4, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x100c_79f9, 5); calld(Definitions.sys_new, 0x9e402);    /* call 0x10165e00 */
            ii(0x100c_79fe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_7a01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7a04, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_7a07, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_7a0b, 2); if(jzd(0x100c_7a2a, 0x1d)) goto l_0x100c_7a2a; /* jz 0x100c7a2a */
            ii(0x100c_7a0d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7a10, 5); calld(0x100c_b6f0, 0x3cdb);             /* call 0x100cb6f0 */
            ii(0x100c_7a15, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7a17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7a1a, 5); calld(0x100c_a2f8, 0x28d9);             /* call 0x100ca2f8 */
            ii(0x100c_7a1f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_7a22, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7a25, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_7a28, 2); jmpd(0x100c_7a30, 0x6); goto l_0x100c_7a30; /* jmp 0x100c7a30 */
        l_0x100c_7a2a:
            ii(0x100c_7a2a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7a2d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x100c_7a30:
            ii(0x100c_7a30, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100c_7a33, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7a36, 5); calld(0x100c_b77c, 0x3d41);             /* call 0x100cb77c */
            ii(0x100c_7a3b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7a3e, 5); calld(0x1007_6730, -0x51313);           /* call 0x10076730 */
            ii(0x100c_7a43, 5); calld(0x100c_b7e4, 0x3d9c);             /* call 0x100cb7e4 */
            ii(0x100c_7a48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7a4a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7a4d, 5); calld(0x1007_6730, -0x51322);           /* call 0x10076730 */
            ii(0x100c_7a52, 5); calld(0x100c_b7b4, 0x3d5d);             /* call 0x100cb7b4 */
            ii(0x100c_7a57, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_7a5a, 3); mov(edx, memd_a32[ds, edx + 0x6]);      /* mov edx, [edx+0x6] */
            ii(0x100c_7a5d, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100c_7a60, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7a63, 5); calld(0x1007_6730, -0x51338);           /* call 0x10076730 */
            ii(0x100c_7a68, 5); calld(0x1016_3b41, 0x9c0d4);            /* call 0x10163b41 */
            ii(0x100c_7a6d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_7a6f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_7a72, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x100c_7a75, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x100c_7a78, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_7a7b, 3); mov(edx, memd_a32[ds, edx + 0x8]);      /* mov edx, [edx+0x8] */
            ii(0x100c_7a7e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_7a81, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_7a84, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_7a87, 5); calld(0x100d_fd69, 0x182dd);            /* call 0x100dfd69 */
            ii(0x100c_7a8c, 3); add(memw_a32[ds, ecx], ax);             /* add [ecx], ax */
            ii(0x100c_7a8f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7a92, 5); calld(0x100c_b74c, 0x3cb5);             /* call 0x100cb74c */
            ii(0x100c_7a97, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_7a9a, 3); mov(edx, memd_a32[ds, edx + 0x8]);      /* mov edx, [edx+0x8] */
            ii(0x100c_7a9d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_7aa0, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100c_7aa3, 3); movsx(ecx, memw_a32[ds, ecx]);          /* movsx ecx, word [ecx] */
            ii(0x100c_7aa6, 6); imul(ecx, ecx, 0x247);                  /* imul ecx, ecx, 0x247 */
            ii(0x100c_7aac, 6); mov(ecx, memd_a32[ds, ecx + 0x101c_a562]); /* mov ecx, [ecx+0x101ca562] */
            ii(0x100c_7ab2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_7ab4, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_7ab6, 5); calld(0x100c_b63c, 0x3b81);             /* call 0x100cb63c */
            ii(0x100c_7abb, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100c_7ac2, 2); if(jzd(0x100c_7ad8, 0x14)) goto l_0x100c_7ad8; /* jz 0x100c7ad8 */
            ii(0x100c_7ac4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_7ac7, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100c_7aca, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_7acd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_7ad0, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_7ad3, 5); calld(0x1012_8a34, 0x60f5c);            /* call 0x10128a34 */
        l_0x100c_7ad8:
            ii(0x100c_7ad8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7ada, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_7add, 5); calld(0x1007_5eec, -0x51bf6);           /* call 0x10075eec */
        l_0x100c_7ae2:
            ii(0x100c_7ae2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7ae4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_7ae5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_7ae6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_7ae7, 1); popd(edx);                              /* pop edx */
            ii(0x100c_7ae8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_7ae9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_7aea, 1); retd(); return;                         /* ret */
        }
    }
}
