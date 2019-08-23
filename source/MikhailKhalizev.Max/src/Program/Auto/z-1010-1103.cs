using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_1103-cbad0040")]
        public void Method_1010_1103()
        {
            ii(0x1010_1103, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_1108, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4c45); /* call 0x10165d52 */
            ii(0x1010_110d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_110e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_110f, 1); pushd(edx);                             /* push edx */
            ii(0x1010_1110, 1); pushd(esi);                             /* push esi */
            ii(0x1010_1111, 1); pushd(edi);                             /* push edi */
            ii(0x1010_1112, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_1113, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_1115, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_111b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_111e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_1121, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1010_1125, 6); if(jzd(0x1010_1197, 0x6c)) goto l_0x1010_1197; /* jz 0x10101197 */
            ii(0x1010_112b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_112e, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1010_1132, 7); cmp(ax, memw_a32[ds, 0x101c_38de]);     /* cmp ax, [0x101c38de] */
            ii(0x1010_1139, 2); if(jgd(0x1010_114b, 0x10)) goto l_0x1010_114b; /* jg 0x1010114b */
            ii(0x1010_113b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_113e, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1010_1142, 7); cmp(ax, memw_a32[ds, 0x101c_38e0]);     /* cmp ax, [0x101c38e0] */
            ii(0x1010_1149, 2); if(jled(0x1010_114d, 0x2)) goto l_0x1010_114d; /* jle 0x1010114d */
        l_0x1010_114b:
            ii(0x1010_114b, 2); jmpd(0x1010_1164, 0x17); goto l_0x1010_1164; /* jmp 0x10101164 */
        l_0x1010_114d:
            ii(0x1010_114d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_1150, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1010_1153, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1156, 6); mov(edx, memd_a32[ds, 0x101c_38d8]);    /* mov edx, [0x101c38d8] */
            ii(0x1010_115c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_115f, 1); inc(eax);                               /* inc eax */
            ii(0x1010_1160, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1010_1162, 2); if(jged(0x1010_1166, 0x2)) goto l_0x1010_1166; /* jge 0x10101166 */
        l_0x1010_1164:
            ii(0x1010_1164, 2); jmpd(0x1010_117d, 0x17); goto l_0x1010_117d; /* jmp 0x1010117d */
        l_0x1010_1166:
            ii(0x1010_1166, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_1169, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1010_116c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_116f, 6); mov(edx, memd_a32[ds, 0x101c_38da]);    /* mov edx, [0x101c38da] */
            ii(0x1010_1175, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_1178, 1); inc(eax);                               /* inc eax */
            ii(0x1010_1179, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1010_117b, 2); if(jged(0x1010_117f, 0x2)) goto l_0x1010_117f; /* jge 0x1010117f */
        l_0x1010_117d:
            ii(0x1010_117d, 2); jmpd(0x1010_1188, 0x9); goto l_0x1010_1188; /* jmp 0x10101188 */
        l_0x1010_117f:
            ii(0x1010_117f, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1010_1186, 2); jmpd(0x1010_118f, 0x7); goto l_0x1010_118f; /* jmp 0x1010118f */
        l_0x1010_1188:
            ii(0x1010_1188, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1010_118f:
            ii(0x1010_118f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_1192, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_1195, 2); jmpd(0x1010_11f3, 0x5c); goto l_0x1010_11f3; /* jmp 0x101011f3 */
        l_0x1010_1197:
            ii(0x1010_1197, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_119a, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1010_119e, 7); cmp(ax, memw_a32[ds, 0x101c_38de]);     /* cmp ax, [0x101c38de] */
            ii(0x1010_11a5, 2); if(jgd(0x1010_11b7, 0x10)) goto l_0x1010_11b7; /* jg 0x101011b7 */
            ii(0x1010_11a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_11aa, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1010_11ae, 7); cmp(ax, memw_a32[ds, 0x101c_38e0]);     /* cmp ax, [0x101c38e0] */
            ii(0x1010_11b5, 2); if(jled(0x1010_11b9, 0x2)) goto l_0x1010_11b9; /* jle 0x101011b9 */
        l_0x1010_11b7:
            ii(0x1010_11b7, 2); jmpd(0x1010_11c9, 0x10); goto l_0x1010_11c9; /* jmp 0x101011c9 */
        l_0x1010_11b9:
            ii(0x1010_11b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_11bc, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1010_11c0, 7); cmp(ax, memw_a32[ds, 0x101c_38da]);     /* cmp ax, [0x101c38da] */
            ii(0x1010_11c7, 2); if(jged(0x1010_11cb, 0x2)) goto l_0x1010_11cb; /* jge 0x101011cb */
        l_0x1010_11c9:
            ii(0x1010_11c9, 2); jmpd(0x1010_11db, 0x10); goto l_0x1010_11db; /* jmp 0x101011db */
        l_0x1010_11cb:
            ii(0x1010_11cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_11ce, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1010_11d2, 7); cmp(ax, memw_a32[ds, 0x101c_38dc]);     /* cmp ax, [0x101c38dc] */
            ii(0x1010_11d9, 2); if(jged(0x1010_11dd, 0x2)) goto l_0x1010_11dd; /* jge 0x101011dd */
        l_0x1010_11db:
            ii(0x1010_11db, 2); jmpd(0x1010_11e6, 0x9); goto l_0x1010_11e6; /* jmp 0x101011e6 */
        l_0x1010_11dd:
            ii(0x1010_11dd, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_11e4, 2); jmpd(0x1010_11ed, 0x7); goto l_0x1010_11ed; /* jmp 0x101011ed */
        l_0x1010_11e6:
            ii(0x1010_11e6, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_11ed:
            ii(0x1010_11ed, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_11f0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1010_11f3:
            ii(0x1010_11f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_11f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_11f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_11f9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_11fa, 1); popd(esi);                              /* pop esi */
            ii(0x1010_11fb, 1); popd(edx);                              /* pop edx */
            ii(0x1010_11fc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_11fd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_11fe, 1); retd();                                 /* ret */
        }
    }
}
