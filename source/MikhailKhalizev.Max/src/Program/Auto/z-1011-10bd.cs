using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_10bd-76f4ecb8")]
        public void Method_1011_10bd()
        {
            ii(0x1011_10bd, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_10c2, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4c8b); /* call 0x10165d52 */
            ii(0x1011_10c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_10c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_10c9, 1); pushd(edx);                             /* push edx */
            ii(0x1011_10ca, 1); pushd(esi);                             /* push esi */
            ii(0x1011_10cb, 1); pushd(edi);                             /* push edi */
            ii(0x1011_10cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_10cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_10cf, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_10d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_10d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_10db, 4); cmp(memd_a32[ds, eax + 0xc], 0xe);      /* cmp dword [eax+0xc], 0xe */
            ii(0x1011_10df, 6); if(jnzd(0x1011_1159, 0x74)) goto l_0x1011_1159; /* jnz 0x10111159 */
            ii(0x1011_10e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_10e8, 6); mov(eax, memd_a32[ds, eax + 0x148]);    /* mov eax, [eax+0x148] */
            ii(0x1011_10ee, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_10f1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_10f3, 2); if(jzd(0x1011_1154, 0x5f)) goto l_0x1011_1154; /* jz 0x10111154 */
            ii(0x1011_10f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_10f8, 7); mov(ax, memw_a32[ds, eax + 0x14a]);     /* mov ax, [eax+0x14a] */
            ii(0x1011_10ff, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_1102, 7); sub(ax, memw_a32[ds, edx + 0x14c]);     /* sub ax, [edx+0x14c] */
            ii(0x1011_1109, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_110c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_1110, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1112, 2); if(jged(0x1011_111b, 0x7)) goto l_0x1011_111b; /* jge 0x1011111b */
            ii(0x1011_1114, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1011_111b:
            ii(0x1011_111b, 5); calld(0x1014_82f4, 0x3_71d4);           /* call 0x101482f4 */
            ii(0x1011_1120, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_1123, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1126, 7); dec(memw_a32[ds, eax + 0x14a]);         /* dec word [eax+0x14a] */
            ii(0x1011_112d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1130, 5); calld(0x1011_0357, -0xdde);             /* call 0x10110357 */
        l_0x1011_1135:
            ii(0x1011_1135, 5); calld(0x1014_82f4, 0x3_71ba);           /* call 0x101482f4 */
            ii(0x1011_113a, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1011_113d, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1011_1142, 2); if(jbd(0x1011_1135, -0xf)) goto l_0x1011_1135; /* jb 0x10111135 */
            ii(0x1011_1144, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1147, 7); mov(ax, memw_a32[ds, eax + 0x14a]);     /* mov ax, [eax+0x14a] */
            ii(0x1011_114e, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_1152, 2); if(jnzd(0x1011_111b, -0x39)) goto l_0x1011_111b; /* jnz 0x1011111b */
        l_0x1011_1154:
            ii(0x1011_1154, 5); jmpd(0x1011_11d3, 0x7a); goto l_0x1011_11d3; /* jmp 0x101111d3 */
        l_0x1011_1159:
            ii(0x1011_1159, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_115c, 6); mov(edx, memd_a32[ds, eax + 0x148]);    /* mov edx, [eax+0x148] */
            ii(0x1011_1162, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_1165, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1168, 6); mov(eax, memd_a32[ds, eax + 0x14a]);    /* mov eax, [eax+0x14a] */
            ii(0x1011_116e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_1171, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_1173, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1176, 6); mov(eax, memd_a32[ds, eax + 0x146]);    /* mov eax, [eax+0x146] */
            ii(0x1011_117c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_117f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_1181, 2); if(jged(0x1011_11d3, 0x50)) goto l_0x1011_11d3; /* jge 0x101111d3 */
            ii(0x1011_1183, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1186, 7); mov(ax, memw_a32[ds, eax + 0x14a]);     /* mov ax, [eax+0x14a] */
            ii(0x1011_118d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_1190, 7); add(ax, memw_a32[ds, edx + 0x14c]);     /* add ax, [edx+0x14c] */
            ii(0x1011_1197, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1011_119a:
            ii(0x1011_119a, 5); calld(0x1014_82f4, 0x3_7155);           /* call 0x101482f4 */
            ii(0x1011_119f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_11a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_11a5, 7); inc(memw_a32[ds, eax + 0x14a]);         /* inc word [eax+0x14a] */
            ii(0x1011_11ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_11af, 5); calld(0x1011_0357, -0xe5d);             /* call 0x10110357 */
        l_0x1011_11b4:
            ii(0x1011_11b4, 5); calld(0x1014_82f4, 0x3_713b);           /* call 0x101482f4 */
            ii(0x1011_11b9, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x1011_11bc, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1011_11c1, 2); if(jbd(0x1011_11b4, -0xf)) goto l_0x1011_11b4; /* jb 0x101111b4 */
            ii(0x1011_11c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_11c6, 7); mov(ax, memw_a32[ds, eax + 0x14a]);     /* mov ax, [eax+0x14a] */
            ii(0x1011_11cd, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1011_11d1, 2); if(jnzd(0x1011_119a, -0x39)) goto l_0x1011_119a; /* jnz 0x1011119a */
        l_0x1011_11d3:
            ii(0x1011_11d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_11d5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_11d6, 1); popd(edi);                              /* pop edi */
            ii(0x1011_11d7, 1); popd(esi);                              /* pop esi */
            ii(0x1011_11d8, 1); popd(edx);                              /* pop edx */
            ii(0x1011_11d9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_11da, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_11db, 1); retd(); return;                         /* ret */
        }
    }
}
