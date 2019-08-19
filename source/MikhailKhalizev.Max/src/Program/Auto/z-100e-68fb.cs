using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_68fb-c49eeb0e")]
        public void Method_100e_68fb()
        {
            ii(0x100e_68fb, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x100e_6900, 5); calld(Definitions.sys_check_available_stack_size, 0x7_f44d); /* call 0x10165d52 */
            ii(0x100e_6905, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_6906, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_6907, 1); pushd(esi);                             /* push esi */
            ii(0x100e_6908, 1); pushd(edi);                             /* push edi */
            ii(0x100e_6909, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_690a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_690c, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100e_6912, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_6915, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_6918, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_691d, 5); calld(0x100e_883d, 0x1f1b);             /* call 0x100e883d */
            ii(0x100e_6922, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_6925, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6928, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100e_692c, 2); if(jzd(0x100e_6937, 0x9)) goto l_0x100e_6937; /* jz 0x100e6937 */
            ii(0x100e_692e, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x100e_6935, 2); jmpd(0x100e_693e, 0x7); goto l_0x100e_693e; /* jmp 0x100e693e */
        l_0x100e_6937:
            ii(0x100e_6937, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
        l_0x100e_693e:
            ii(0x100e_693e, 3); mov(cl, memb_a32[ss, ebp - 0x30]);      /* mov cl, [ebp-0x30] */
            ii(0x100e_6941, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100e_6946, 2); sar(edx, cl);                           /* sar edx, cl */
            ii(0x100e_6948, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_694b, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_694e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_6951, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6953, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_6956, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100e_695a, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_695d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_695f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6962, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_6968, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_696e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_6971, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6973, 1); inc(eax);                               /* inc eax */
            ii(0x100e_6974, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_6977, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_697a, 4); test(memb_a32[ds, edx + 0x12], 0x10);   /* test byte [edx+0x12], 0x10 */
            ii(0x100e_697e, 2); if(jzd(0x100e_6989, 0x9)) goto l_0x100e_6989; /* jz 0x100e6989 */
            ii(0x100e_6980, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100e_6987, 2); jmpd(0x100e_6990, 0x7); goto l_0x100e_6990; /* jmp 0x100e6990 */
        l_0x100e_6989:
            ii(0x100e_6989, 7); mov(memd_a32[ss, ebp - 0x34], 0x1);     /* mov dword [ebp-0x34], 0x1 */
        l_0x100e_6990:
            ii(0x100e_6990, 3); mov(cl, memb_a32[ss, ebp - 0x34]);      /* mov cl, [ebp-0x34] */
            ii(0x100e_6993, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100e_6998, 2); sar(edx, cl);                           /* sar edx, cl */
            ii(0x100e_699a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_699d, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_69a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_69a3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_69a5, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_69a8, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100e_69ac, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_69af, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_69b1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_69b4, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_69ba, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_69c0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_69c3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_69c5, 1); inc(eax);                               /* inc eax */
            ii(0x100e_69c6, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_69c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_69cc, 4); test(memb_a32[ds, edx + 0x12], 0x10);   /* test byte [edx+0x12], 0x10 */
            ii(0x100e_69d0, 2); if(jzd(0x100e_69db, 0x9)) goto l_0x100e_69db; /* jz 0x100e69db */
            ii(0x100e_69d2, 7); mov(memd_a32[ss, ebp - 0x2c], 0x80);    /* mov dword [ebp-0x2c], 0x80 */
            ii(0x100e_69d9, 2); jmpd(0x100e_69e2, 0x7); goto l_0x100e_69e2; /* jmp 0x100e69e2 */
        l_0x100e_69db:
            ii(0x100e_69db, 7); mov(memd_a32[ss, ebp - 0x2c], 0x40);    /* mov dword [ebp-0x2c], 0x40 */
        l_0x100e_69e2:
            ii(0x100e_69e2, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_69e5, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_69e8, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100e_69ec, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_69ef, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_69f1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_69f4, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_69fa, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100e_69fd, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_6a00, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6a03, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x100e_6a06, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_6a09, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6a0c, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x100e_6a0f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_6a12, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_6a16, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6a18, 2); if(jld(0x100e_6a22, 0x8)) goto l_0x100e_6a22; /* jl 0x100e6a22 */
            ii(0x100e_6a1a, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_6a1e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6a20, 2); if(jged(0x100e_6a24, 0x2)) goto l_0x100e_6a24; /* jge 0x100e6a24 */
        l_0x100e_6a22:
            ii(0x100e_6a22, 2); jmpd(0x100e_6a30, 0xc); goto l_0x100e_6a30; /* jmp 0x100e6a30 */
        l_0x100e_6a24:
            ii(0x100e_6a24, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6a27, 7); cmp(ax, memw_a32[ds, 0x101b_8748]);     /* cmp ax, [0x101b8748] */
            ii(0x100e_6a2e, 2); if(jld(0x100e_6a32, 0x2)) goto l_0x100e_6a32; /* jl 0x100e6a32 */
        l_0x100e_6a30:
            ii(0x100e_6a30, 2); jmpd(0x100e_6a3e, 0xc); goto l_0x100e_6a3e; /* jmp 0x100e6a3e */
        l_0x100e_6a32:
            ii(0x100e_6a32, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6a35, 7); cmp(ax, memw_a32[ds, 0x101b_874a]);     /* cmp ax, [0x101b874a] */
            ii(0x100e_6a3c, 2); if(jld(0x100e_6a43, 0x5)) goto l_0x100e_6a43; /* jl 0x100e6a43 */
        l_0x100e_6a3e:
            ii(0x100e_6a3e, 5); jmpd(0x100e_6d2e, 0x2eb); goto l_0x100e_6d2e; /* jmp 0x100e6d2e */
        l_0x100e_6a43:
            ii(0x100e_6a43, 7); cmp(memb_a32[ds, 0x101c_37cd], 0);      /* cmp byte [0x101c37cd], 0x0 */
            ii(0x100e_6a4a, 2); if(jzd(0x100e_6a55, 0x9)) goto l_0x100e_6a55; /* jz 0x100e6a55 */
            ii(0x100e_6a4c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6a4f, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100e_6a53, 2); if(jzd(0x100e_6a5a, 0x5)) goto l_0x100e_6a5a; /* jz 0x100e6a5a */
        l_0x100e_6a55:
            ii(0x100e_6a55, 5); jmpd(0x100e_6ac9, 0x6f); goto l_0x100e_6ac9; /* jmp 0x100e6ac9 */
        l_0x100e_6a5a:
            ii(0x100e_6a5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6a5d, 4); test(memb_a32[ds, eax + 0x13], 0x20);   /* test byte [eax+0x13], 0x20 */
            ii(0x100e_6a61, 2); if(jzd(0x100e_6a6c, 0x9)) goto l_0x100e_6a6c; /* jz 0x100e6a6c */
            ii(0x100e_6a63, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x100e_6a6a, 2); jmpd(0x100e_6aa9, 0x3d); goto l_0x100e_6aa9; /* jmp 0x100e6aa9 */
        l_0x100e_6a6c:
            ii(0x100e_6a6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6a6f, 4); test(memb_a32[ds, eax + 0x13], 0x10);   /* test byte [eax+0x13], 0x10 */
            ii(0x100e_6a73, 2); if(jzd(0x100e_6a7e, 0x9)) goto l_0x100e_6a7e; /* jz 0x100e6a7e */
            ii(0x100e_6a75, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
            ii(0x100e_6a7c, 2); jmpd(0x100e_6aa9, 0x2b); goto l_0x100e_6aa9; /* jmp 0x100e6aa9 */
        l_0x100e_6a7e:
            ii(0x100e_6a7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6a81, 4); test(memb_a32[ds, eax + 0x13], 0x8);    /* test byte [eax+0x13], 0x8 */
            ii(0x100e_6a85, 2); if(jzd(0x100e_6a90, 0x9)) goto l_0x100e_6a90; /* jz 0x100e6a90 */
            ii(0x100e_6a87, 7); mov(memd_a32[ss, ebp - 0x14], 0x3);     /* mov dword [ebp-0x14], 0x3 */
            ii(0x100e_6a8e, 2); jmpd(0x100e_6aa9, 0x19); goto l_0x100e_6aa9; /* jmp 0x100e6aa9 */
        l_0x100e_6a90:
            ii(0x100e_6a90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6a93, 4); test(memb_a32[ds, eax + 0x13], 0x4);    /* test byte [eax+0x13], 0x4 */
            ii(0x100e_6a97, 2); if(jzd(0x100e_6aa2, 0x9)) goto l_0x100e_6aa2; /* jz 0x100e6aa2 */
            ii(0x100e_6a99, 7); mov(memd_a32[ss, ebp - 0x14], 0xff);    /* mov dword [ebp-0x14], 0xff */
            ii(0x100e_6aa0, 2); jmpd(0x100e_6aa9, 0x7); goto l_0x100e_6aa9; /* jmp 0x100e6aa9 */
        l_0x100e_6aa2:
            ii(0x100e_6aa2, 7); mov(memd_a32[ss, ebp - 0x14], 0xa9);    /* mov dword [ebp-0x14], 0xa9 */
        l_0x100e_6aa9:
            ii(0x100e_6aa9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_6aad, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6aae, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_6ab1, 3); pushd(memd_a32[ds, eax + 0x16]);        /* push dword [eax+0x16] */
            ii(0x100e_6ab4, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x100e_6ab8, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x100e_6abc, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100e_6ac0, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100e_6ac4, 5); calld(0x100e_67a1, -0x328);             /* call 0x100e67a1 */
        l_0x100e_6ac9:
            ii(0x100e_6ac9, 7); cmp(memb_a32[ds, 0x101c_37cc], 0);      /* cmp byte [0x101c37cc], 0x0 */
            ii(0x100e_6ad0, 2); if(jzd(0x100e_6afd, 0x2b)) goto l_0x100e_6afd; /* jz 0x100e6afd */
            ii(0x100e_6ad2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_6ad5, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100e_6ada, 1); cwde();                                 /* cwde */
            ii(0x100e_6adb, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6adc, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_6adf, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100e_6ae4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_6ae7, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6aea, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6aeb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6aee, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6af1, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6af2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_6af5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6af8, 5); calld(0x100e_6568, -0x595);             /* call 0x100e6568 */
        l_0x100e_6afd:
            ii(0x100e_6afd, 7); cmp(memd_a32[ds, 0x101c_38c0], 0x8);    /* cmp dword [0x101c38c0], 0x8 */
            ii(0x100e_6b04, 2); if(jled(0x100e_6b1a, 0x14)) goto l_0x100e_6b1a; /* jle 0x100e6b1a */
            ii(0x100e_6b06, 7); cmp(memb_a32[ds, 0x101c_37ce], 0);      /* cmp byte [0x101c37ce], 0x0 */
            ii(0x100e_6b0d, 2); if(jnzd(0x100e_6b18, 0x9)) goto l_0x100e_6b18; /* jnz 0x100e6b18 */
            ii(0x100e_6b0f, 7); cmp(memb_a32[ds, 0x101c_37cf], 0);      /* cmp byte [0x101c37cf], 0x0 */
            ii(0x100e_6b16, 2); if(jzd(0x100e_6b1a, 0x2)) goto l_0x100e_6b1a; /* jz 0x100e6b1a */
        l_0x100e_6b18:
            ii(0x100e_6b18, 2); jmpd(0x100e_6b1f, 0x5); goto l_0x100e_6b1f; /* jmp 0x100e6b1f */
        l_0x100e_6b1a:
            ii(0x100e_6b1a, 5); jmpd(0x100e_6d2e, 0x20f); goto l_0x100e_6d2e; /* jmp 0x100e6d2e */
        l_0x100e_6b1f:
            ii(0x100e_6b1f, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100e_6b23, 3); sar(eax, 0x3);                          /* sar eax, 0x3 */
            ii(0x100e_6b26, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_6b29, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_6b2d, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100e_6b30, 2); if(jged(0x100e_6b39, 0x7)) goto l_0x100e_6b39; /* jge 0x100e6b39 */
            ii(0x100e_6b32, 7); mov(memd_a32[ss, ebp - 0x10], 0x3);     /* mov dword [ebp-0x10], 0x3 */
        l_0x100e_6b39:
            ii(0x100e_6b39, 5); mov(eax, 0x10_0000);                    /* mov eax, 0x100000 */
            ii(0x100e_6b3e, 5); mov(edx, 0x10_0000);                    /* mov edx, 0x100000 */
            ii(0x100e_6b43, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6b46, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_6b4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_6b4e, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100e_6b52, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6b54, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_6b57, 5); mov(eax, 0x8_0000);                     /* mov eax, 0x80000 */
            ii(0x100e_6b5c, 5); mov(edx, 0x8_0000);                     /* mov edx, 0x80000 */
            ii(0x100e_6b61, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6b64, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_6b6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_6b6c, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100e_6b70, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_6b72, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_6b75, 5); mov(eax, 0x6_0000);                     /* mov eax, 0x60000 */
            ii(0x100e_6b7a, 5); mov(edx, 0x6_0000);                     /* mov edx, 0x60000 */
            ii(0x100e_6b7f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6b82, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_6b88, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_6b8a, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_6b8e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_6b90, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_6b93, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6b96, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x100e_6b99, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6b9a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_6b9d, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6ba0, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_6ba3, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6ba4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_6ba7, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100e_6bae, 2); jmpd(0x100e_6bb6, 0x6); goto l_0x100e_6bb6; /* jmp 0x100e6bb6 */
        l_0x100e_6bb0:
            ii(0x100e_6bb0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_6bb3, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100e_6bb6:
            ii(0x100e_6bb6, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_6bba, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_6bbd, 6); if(jgd(0x100e_6d2e, 0x16b)) goto l_0x100e_6d2e; /* jg 0x100e6d2e */
            ii(0x100e_6bc3, 7); mov(memd_a32[ss, ebp - 0x3c], 0);       /* mov dword [ebp-0x3c], 0x0 */
            ii(0x100e_6bca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_6bcd, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100e_6bd0, 5); jmpd(0x100e_6c51, 0x7c); goto l_0x100e_6c51; /* jmp 0x100e6c51 */
        l_0x100e_6bd5:
            ii(0x100e_6bd5, 7); cmp(memb_a32[ds, 0x101c_37ce], 0);      /* cmp byte [0x101c37ce], 0x0 */
            ii(0x100e_6bdc, 2); if(jzd(0x100e_6bed, 0xf)) goto l_0x100e_6bed; /* jz 0x100e6bed */
            ii(0x100e_6bde, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6be1, 5); calld(0x1007_623c, -0x7_09aa);          /* call 0x1007623c */
            ii(0x100e_6be6, 4); mov(ax, memw_a32[ds, eax + 0xa]);       /* mov ax, [eax+0xa] */
            ii(0x100e_6bea, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x100e_6bed:
            ii(0x100e_6bed, 4); movsx(edx, memw_a32[ss, ebp - 0x3c]);   /* movsx edx, word [ebp-0x3c] */
            ii(0x100e_6bf1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6bf4, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100e_6bf7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_6bfc, 5); calld(Definitions.my_min, -0x5_d47d);   /* call 0x10089784 */
            ii(0x100e_6c01, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100e_6c04, 5); jmpd(0x100e_6c6d, 0x64); goto l_0x100e_6c6d; /* jmp 0x100e6c6d */
        l_0x100e_6c09:
            ii(0x100e_6c09, 7); cmp(memb_a32[ds, 0x101c_37cf], 0);      /* cmp byte [0x101c37cf], 0x0 */
            ii(0x100e_6c10, 2); if(jzd(0x100e_6c25, 0x13)) goto l_0x100e_6c25; /* jz 0x100e6c25 */
            ii(0x100e_6c12, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6c15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_6c17, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_6c1a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_6c1c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_6c21, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_6c23, 2); if(jzd(0x100e_6c27, 0x2)) goto l_0x100e_6c27; /* jz 0x100e6c27 */
        l_0x100e_6c25:
            ii(0x100e_6c25, 2); jmpd(0x100e_6c36, 0xf); goto l_0x100e_6c36; /* jmp 0x100e6c36 */
        l_0x100e_6c27:
            ii(0x100e_6c27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6c2a, 5); calld(0x1007_623c, -0x7_09f3);          /* call 0x1007623c */
            ii(0x100e_6c2f, 4); mov(ax, memw_a32[ds, eax + 0x1b]);      /* mov ax, [eax+0x1b] */
            ii(0x100e_6c33, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x100e_6c36:
            ii(0x100e_6c36, 4); movsx(edx, memw_a32[ss, ebp - 0x3c]);   /* movsx edx, word [ebp-0x3c] */
            ii(0x100e_6c3a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6c3d, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100e_6c40, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_6c45, 5); calld(Definitions.my_min, -0x5_d4c6);   /* call 0x10089784 */
            ii(0x100e_6c4a, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100e_6c4d, 2); jmpd(0x100e_6c6d, 0x1e); goto l_0x100e_6c6d; /* jmp 0x100e6c6d */
        l_0x100e_6c4f:
            ii(0x100e_6c4f, 2); jmpd(0x100e_6c6d, 0x1c); goto l_0x100e_6c6d; /* jmp 0x100e6c6d */
        l_0x100e_6c51:
            ii(0x100e_6c51, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100e_6c54, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100e_6c57, 5); cmp(memw_a32[ss, ebp - 0x48], 0);       /* cmp word [ebp-0x48], 0x0 */
            ii(0x100e_6c5c, 6); if(jbed(0x100e_6bd5, -0x8d)) goto l_0x100e_6bd5; /* jbe 0x100e6bd5 */
            ii(0x100e_6c62, 5); cmp(memw_a32[ss, ebp - 0x48], 0x1);     /* cmp word [ebp-0x48], 0x1 */
            ii(0x100e_6c67, 2); if(jzd(0x100e_6c09, -0x60)) goto l_0x100e_6c09; /* jz 0x100e6c09 */
            ii(0x100e_6c69, 2); jmpd(0x100e_6c4f, -0x1c); goto l_0x100e_6c4f; /* jmp 0x100e6c4f */
        //  ii(0x100e_6c6b, 2); jmpd(0x100e_6c4f, -0x1e); goto l_0x100e_6c4f; /* jmp 0x100e6c4f */
        l_0x100e_6c6d:
            ii(0x100e_6c6d, 5); cmp(memw_a32[ss, ebp - 0x3c], 0);       /* cmp word [ebp-0x3c], 0x0 */
            ii(0x100e_6c72, 6); if(jzd(0x100e_6d18, 0xa0)) goto l_0x100e_6d18; /* jz 0x100e6d18 */
            ii(0x100e_6c78, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_6c7a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6c7b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_6c7f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6c80, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x100e_6c84, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x100e_6c88, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100e_6c8c, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_6c8f, 5); calld(0x100e_649b, -0x7f9);             /* call 0x100e649b */
            ii(0x100e_6c94, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100e_6c98, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x100e_6c9c, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x100e_6c9f, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_6ca2, 4); movsx(ebx, memw_a32[ss, ebp - 0x3c]);   /* movsx ebx, word [ebp-0x3c] */
            ii(0x100e_6ca6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6ca8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6cab, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_6cad, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100e_6cb0, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100e_6cb4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6cb6, 2); if(jled(0x100e_6d18, 0x60)) goto l_0x100e_6d18; /* jle 0x100e6d18 */
            ii(0x100e_6cb8, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100e_6cbc, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x100e_6cbf, 4); movsx(edx, memw_a32[ss, ebp - 0x44]);   /* movsx edx, word [ebp-0x44] */
            ii(0x100e_6cc3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_6cc5, 2); if(jgd(0x100e_6cd0, 0x9)) goto l_0x100e_6cd0; /* jg 0x100e6cd0 */
            ii(0x100e_6cc7, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x100e_6cce, 2); jmpd(0x100e_6cee, 0x1e); goto l_0x100e_6cee; /* jmp 0x100e6cee */
        l_0x100e_6cd0:
            ii(0x100e_6cd0, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100e_6cd4, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_6cd6, 4); movsx(edx, memw_a32[ss, ebp - 0x44]);   /* movsx edx, word [ebp-0x44] */
            ii(0x100e_6cda, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_6cdc, 2); if(jgd(0x100e_6ce7, 0x9)) goto l_0x100e_6ce7; /* jg 0x100e6ce7 */
            ii(0x100e_6cde, 7); mov(memd_a32[ss, ebp - 0x14], 0x4);     /* mov dword [ebp-0x14], 0x4 */
            ii(0x100e_6ce5, 2); jmpd(0x100e_6cee, 0x7); goto l_0x100e_6cee; /* jmp 0x100e6cee */
        l_0x100e_6ce7:
            ii(0x100e_6ce7, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
        l_0x100e_6cee:
            ii(0x100e_6cee, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_6cf2, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6cf3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_6cf6, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6cf7, 1); cwde();                                 /* cwde */
            ii(0x100e_6cf8, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6cf9, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6cfc, 3); add(eax, memd_a32[ss, ebp - 0x4c]);     /* add eax, [ebp-0x4c] */
            ii(0x100e_6cff, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_6d02, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6d05, 1); inc(eax);                               /* inc eax */
            ii(0x100e_6d06, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6d09, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6d0c, 1); inc(eax);                               /* inc eax */
            ii(0x100e_6d0d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_6d10, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_6d13, 5); calld(0x100e_649b, -0x87d);             /* call 0x100e649b */
        l_0x100e_6d18:
            ii(0x100e_6d18, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6d1b, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6d1c, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
            ii(0x100e_6d1f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6d22, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_6d25, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6d26, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_6d29, 5); jmpd(0x100e_6bb0, -0x17e); goto l_0x100e_6bb0; /* jmp 0x100e6bb0 */
        l_0x100e_6d2e:
            ii(0x100e_6d2e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_6d30, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_6d31, 1); popd(edi);                              /* pop edi */
            ii(0x100e_6d32, 1); popd(esi);                              /* pop esi */
            ii(0x100e_6d33, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_6d34, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_6d35, 1); retd(); return;                         /* ret */
        }
    }
}
