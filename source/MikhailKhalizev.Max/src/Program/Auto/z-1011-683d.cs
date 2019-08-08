using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fbeed6b-45fe-4cab-adf2-90df9614ec5e")]
        public void Method_1011_683d()
        {
            ii(0x1011_683d, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1011_6842, 5); calld(Definitions.sys_check_available_stack_size, 0x4_f50b); /* call 0x10165d52 */
            ii(0x1011_6847, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_6848, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_6849, 1); pushd(esi);                             /* push esi */
            ii(0x1011_684a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_684b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_684c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_684e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_6854, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_6857, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_685a, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1011_685e, 2); if(jled(0x1011_6869, 0x9)) goto l_0x1011_6869; /* jle 0x10116869 */
            ii(0x1011_6860, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1011_6867, 2); if(jld(0x1011_686b, 0x2)) goto l_0x1011_686b; /* jl 0x1011686b */
        l_0x1011_6869:
            ii(0x1011_6869, 2); jmpd(0x1011_6872, 0x7); goto l_0x1011_6872; /* jmp 0x10116872 */
        l_0x1011_686b:
            ii(0x1011_686b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_686e, 4); mov(memb_a32[ds, eax + 0x3f], 0);       /* mov byte [eax+0x3f], 0x0 */
        l_0x1011_6872:
            ii(0x1011_6872, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6875, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_6878, 5); jmpd(0x1011_6999, 0x11c); goto l_0x1011_6999; /* jmp 0x10116999 */
        l_0x1011_687d:
            ii(0x1011_687d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6880, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
            ii(0x1011_6884, 5); jmpd(0x1011_6a0a, 0x181); goto l_0x1011_6a0a; /* jmp 0x10116a0a */
        l_0x1011_6889:
            ii(0x1011_6889, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_688c, 3); mov(eax, memd_a32[ds, eax + 0x4b]);     /* mov eax, [eax+0x4b] */
            ii(0x1011_688f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_6892, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_6894, 2); if(jzd(0x1011_68e9, 0x53)) goto l_0x1011_68e9; /* jz 0x101168e9 */
            ii(0x1011_6896, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6899, 4); mov(ax, memw_a32[ds, eax + 0x4d]);      /* mov ax, [eax+0x4d] */
            ii(0x1011_689d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_68a0, 4); sub(ax, memw_a32[ds, edx + 0x4b]);      /* sub ax, [edx+0x4b] */
            ii(0x1011_68a4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_68a7, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_68ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_68ad, 2); if(jged(0x1011_68b6, 0x7)) goto l_0x1011_68b6; /* jge 0x101168b6 */
            ii(0x1011_68af, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_68b6:
            ii(0x1011_68b6, 5); calld(0x1014_82f4, 0x3_1a39);           /* call 0x101482f4 */
            ii(0x1011_68bb, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_68be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_68c1, 4); dec(memw_a32[ds, eax + 0x4d]);          /* dec word [eax+0x4d] */
            ii(0x1011_68c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_68c8, 5); calld(0x1011_6695, -0x238);             /* call 0x10116695 */
        l_0x1011_68cd:
            ii(0x1011_68cd, 5); calld(0x1014_82f4, 0x3_1a22);           /* call 0x101482f4 */
            ii(0x1011_68d2, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x1011_68d5, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1011_68da, 2); if(jbd(0x1011_68cd, -0xf)) goto l_0x1011_68cd; /* jb 0x101168cd */
            ii(0x1011_68dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_68df, 4); mov(ax, memw_a32[ds, eax + 0x4d]);      /* mov ax, [eax+0x4d] */
            ii(0x1011_68e3, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1011_68e7, 2); if(jnzd(0x1011_68b6, -0x33)) goto l_0x1011_68b6; /* jnz 0x101168b6 */
        l_0x1011_68e9:
            ii(0x1011_68e9, 5); jmpd(0x1011_6a0a, 0x11c); goto l_0x1011_6a0a; /* jmp 0x10116a0a */
        l_0x1011_68ee:
            ii(0x1011_68ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_68f1, 3); mov(edx, memd_a32[ds, eax + 0x4b]);     /* mov edx, [eax+0x4b] */
            ii(0x1011_68f4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_68f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_68fa, 3); mov(eax, memd_a32[ds, eax + 0x49]);     /* mov eax, [eax+0x49] */
            ii(0x1011_68fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_6900, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_6902, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6905, 3); mov(eax, memd_a32[ds, eax + 0x47]);     /* mov eax, [eax+0x47] */
            ii(0x1011_6908, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_690b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_690d, 2); if(jged(0x1011_6953, 0x44)) goto l_0x1011_6953; /* jge 0x10116953 */
            ii(0x1011_690f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6912, 4); mov(ax, memw_a32[ds, eax + 0x4d]);      /* mov ax, [eax+0x4d] */
            ii(0x1011_6916, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_6919, 4); add(ax, memw_a32[ds, edx + 0x4b]);      /* add ax, [edx+0x4b] */
            ii(0x1011_691d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1011_6920:
            ii(0x1011_6920, 5); calld(0x1014_82f4, 0x3_19cf);           /* call 0x101482f4 */
            ii(0x1011_6925, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_6928, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_692b, 4); inc(memw_a32[ds, eax + 0x4d]);          /* inc word [eax+0x4d] */
            ii(0x1011_692f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6932, 5); calld(0x1011_6695, -0x2a2);             /* call 0x10116695 */
        l_0x1011_6937:
            ii(0x1011_6937, 5); calld(0x1014_82f4, 0x3_19b8);           /* call 0x101482f4 */
            ii(0x1011_693c, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1011_693f, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1011_6944, 2); if(jbd(0x1011_6937, -0xf)) goto l_0x1011_6937; /* jb 0x10116937 */
            ii(0x1011_6946, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6949, 4); mov(ax, memw_a32[ds, eax + 0x4d]);      /* mov ax, [eax+0x4d] */
            ii(0x1011_694d, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1011_6951, 2); if(jnzd(0x1011_6920, -0x33)) goto l_0x1011_6920; /* jnz 0x10116920 */
        l_0x1011_6953:
            ii(0x1011_6953, 5); jmpd(0x1011_6a0a, 0xb2); goto l_0x1011_6a0a; /* jmp 0x10116a0a */
        l_0x1011_6958:
            ii(0x1011_6958, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1011_695f, 2); if(jld(0x1011_696a, 0x9)) goto l_0x1011_696a; /* jl 0x1011696a */
            ii(0x1011_6961, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6964, 4); cmp(memb_a32[ds, eax + 0x3f], 0);       /* cmp byte [eax+0x3f], 0x0 */
            ii(0x1011_6968, 2); if(jzd(0x1011_696c, 0x2)) goto l_0x1011_696c; /* jz 0x1011696c */
        l_0x1011_696a:
            ii(0x1011_696a, 2); jmpd(0x1011_6994, 0x28); goto l_0x1011_6994; /* jmp 0x10116994 */
        l_0x1011_696c:
            ii(0x1011_696c, 7); cmp(memd_a32[ss, ebp - 0x4], 0x700d);   /* cmp dword [ebp-0x4], 0x700d */
            ii(0x1011_6973, 2); if(jnzd(0x1011_6982, 0xd)) goto l_0x1011_6982; /* jnz 0x10116982 */
            ii(0x1011_6975, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6978, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1011_697b, 5); calld(0x100c_fbbe, -0x4_6dc2);          /* call 0x100cfbbe */
            ii(0x1011_6980, 2); jmpd(0x1011_698d, 0xb); goto l_0x1011_698d; /* jmp 0x1011698d */
        l_0x1011_6982:
            ii(0x1011_6982, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6985, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1011_6988, 5); calld(0x100c_fbbe, -0x4_6dcf);          /* call 0x100cfbbe */
        l_0x1011_698d:
            ii(0x1011_698d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6990, 4); mov(memb_a32[ds, eax + 0x3f], 0x1);     /* mov byte [eax+0x3f], 0x1 */
        l_0x1011_6994:
            ii(0x1011_6994, 5); jmpd(0x1011_6a0a, 0x71); goto l_0x1011_6a0a; /* jmp 0x10116a0a */
        l_0x1011_6999:
            ii(0x1011_6999, 7); cmp(memd_a32[ss, ebp - 0x10], 0x149);   /* cmp dword [ebp-0x10], 0x149 */
            ii(0x1011_69a0, 2); if(jbd(0x1011_69e6, 0x44)) goto l_0x1011_69e6; /* jb 0x101169e6 */
            ii(0x1011_69a2, 7); cmp(memd_a32[ss, ebp - 0x10], 0x149);   /* cmp dword [ebp-0x10], 0x149 */
            ii(0x1011_69a9, 6); if(jbed(0x1011_6889, -0x126)) goto l_0x1011_6889; /* jbe 0x10116889 */
            ii(0x1011_69af, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e8);   /* cmp dword [ebp-0x10], 0x3e8 */
            ii(0x1011_69b6, 2); if(jbd(0x1011_69d4, 0x1c)) goto l_0x1011_69d4; /* jb 0x101169d4 */
            ii(0x1011_69b8, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e8);   /* cmp dword [ebp-0x10], 0x3e8 */
            ii(0x1011_69bf, 6); if(jbed(0x1011_6889, -0x13c)) goto l_0x1011_6889; /* jbe 0x10116889 */
            ii(0x1011_69c5, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x1011_69cc, 6); if(jzd(0x1011_68ee, -0xe4)) goto l_0x1011_68ee; /* jz 0x101168ee */
            ii(0x1011_69d2, 2); jmpd(0x1011_6958, -0x7c); goto l_0x1011_6958; /* jmp 0x10116958 */
        l_0x1011_69d4:
            ii(0x1011_69d4, 7); cmp(memd_a32[ss, ebp - 0x10], 0x151);   /* cmp dword [ebp-0x10], 0x151 */
            ii(0x1011_69db, 6); if(jzd(0x1011_68ee, -0xf3)) goto l_0x1011_68ee; /* jz 0x101168ee */
            ii(0x1011_69e1, 5); jmpd(0x1011_6958, -0x8e); goto l_0x1011_6958; /* jmp 0x10116958 */
        l_0x1011_69e6:
            ii(0x1011_69e6, 4); cmp(memd_a32[ss, ebp - 0x10], 0xd);     /* cmp dword [ebp-0x10], 0xd */
            ii(0x1011_69ea, 2); if(jbd(0x1011_6a05, 0x19)) goto l_0x1011_6a05; /* jb 0x10116a05 */
            ii(0x1011_69ec, 4); cmp(memd_a32[ss, ebp - 0x10], 0xd);     /* cmp dword [ebp-0x10], 0xd */
            ii(0x1011_69f0, 6); if(jbed(0x1011_687d, -0x179)) goto l_0x1011_687d; /* jbe 0x1011687d */
            ii(0x1011_69f6, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1b);    /* cmp dword [ebp-0x10], 0x1b */
            ii(0x1011_69fa, 6); if(jzd(0x1011_687d, -0x183)) goto l_0x1011_687d; /* jz 0x1011687d */
            ii(0x1011_6a00, 5); jmpd(0x1011_6958, -0xad); goto l_0x1011_6958; /* jmp 0x10116958 */
        l_0x1011_6a05:
            ii(0x1011_6a05, 5); jmpd(0x1011_6958, -0xb2); goto l_0x1011_6958; /* jmp 0x10116958 */
        l_0x1011_6a0a:
            ii(0x1011_6a0a, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1011_6a0e, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_6a11, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6a13, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_6a14, 1); popd(edi);                              /* pop edi */
            ii(0x1011_6a15, 1); popd(esi);                              /* pop esi */
            ii(0x1011_6a16, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_6a17, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_6a18, 1); retd(); return;                         /* ret */
        }
    }
}
