using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eee4f8e9-2318-4660-b831-f57d044b6fb6")]
        public void Method_1010_7221()
        {
            ii(0x1010_7221, 5); pushd(0x264);                           /* push 0x264 */
            ii(0x1010_7226, 5); calld(Definitions.sys_check_available_stack_size, 0x5eb27); /* call 0x10165d52 */
            ii(0x1010_722b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_722c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_722d, 1); pushd(edx);                             /* push edx */
            ii(0x1010_722e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_722f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_7230, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_7231, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7233, 6); sub(esp, 0x248);                        /* sub esp, 0x248 */
            ii(0x1010_7239, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_723c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_723f, 3); add(eax, 0x50);                         /* add eax, 0x50 */
            ii(0x1010_7242, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_7245, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_7248, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1010_724c, 2); if(jzd(0x1010_7259, 0xb)) goto l_0x1010_7259; /* jz 0x10107259 */
            ii(0x1010_724e, 6); inc(memd_a32[ds, 0x101c_4db0]);         /* inc dword [0x101c4db0] */
            ii(0x1010_7254, 5); jmpd(0x1010_7444, 0x1eb); goto l_0x1010_7444; /* jmp 0x10107444 */
        l_0x1010_7259:
            ii(0x1010_7259, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_725c, 4); cmp(memb_a32[ds, eax + 0x9], 0);        /* cmp byte [eax+0x9], 0x0 */
            ii(0x1010_7260, 2); if(jzd(0x1010_726d, 0xb)) goto l_0x1010_726d; /* jz 0x1010726d */
            ii(0x1010_7262, 6); inc(memd_a32[ds, 0x101c_4db0]);         /* inc dword [0x101c4db0] */
            ii(0x1010_7268, 5); jmpd(0x1010_7444, 0x1d7); goto l_0x1010_7444; /* jmp 0x10107444 */
        l_0x1010_726d:
            ii(0x1010_726d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_7270, 5); calld(0x1010_6fae, -0x2c7);             /* call 0x10106fae */
            ii(0x1010_7275, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_7277, 6); if(jzd(0x1010_743d, 0x1c0)) goto l_0x1010_743d; /* jz 0x1010743d */
            ii(0x1010_727d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_7280, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1010_7283, 5); calld(0x1010_6f3f, -0x349);             /* call 0x10106f3f */
            ii(0x1010_7288, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_728b, 7); cmp(memb_a32[ds, 0x101c_5630], 0x1);    /* cmp byte [0x101c5630], 0x1 */
            ii(0x1010_7292, 2); if(jzd(0x1010_729d, 0x9)) goto l_0x1010_729d; /* jz 0x1010729d */
            ii(0x1010_7294, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_7298, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1010_729b, 2); if(jnzd(0x1010_72f7, 0x5a)) goto l_0x1010_72f7; /* jnz 0x101072f7 */
        l_0x1010_729d:
            ii(0x1010_729d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_729f, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_72a4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_72a7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_72ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_72ad, 6); mov(dl, memb_a32[ds, eax + 0x101c_40b8]); /* mov dl, [eax+0x101c40b8] */
            ii(0x1010_72b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_72b6, 3); mov(memd_a32[ds, eax + 0x48], edx);     /* mov [eax+0x48], edx */
            ii(0x1010_72b9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1010_72be, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_72c1, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_72c5, 5); calld(0x1010_7083, -0x247);             /* call 0x10107083 */
            ii(0x1010_72ca, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_72ce, 6); inc(memb_a32[ds, eax + 0x101c_40b8]);   /* inc byte [eax+0x101c40b8] */
            ii(0x1010_72d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_72d6, 6); mov(dl, memb_a32[ds, eax + 0x101c_40b8]); /* mov dl, [eax+0x101c40b8] */
            ii(0x1010_72dc, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1010_72e1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_72e3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_72e6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_72e8, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_72ec, 6); mov(memb_a32[ds, eax + 0x101c_40b8], dl); /* mov [eax+0x101c40b8], dl */
            ii(0x1010_72f2, 5); jmpd(0x1010_743d, 0x146); goto l_0x1010_743d; /* jmp 0x1010743d */
        l_0x1010_72f7:
            ii(0x1010_72f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_72fa, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1010_72fc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_7301, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1010_7306, 6); if(jnzd(0x1010_742f, 0x123)) goto l_0x1010_742f; /* jnz 0x1010742f */
            ii(0x1010_730c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_730f, 4); movsx(eax, memw_a32[ds, eax + 0x1]);    /* movsx eax, word [eax+0x1] */
            ii(0x1010_7313, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_7316, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_731a, 3); shl(eax, 0x7);                          /* shl eax, 0x7 */
            ii(0x1010_731d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_731f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_7322, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_7324, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7326, 7); mov(ax, memw_a32[ds, eax + 0x101c_4780]); /* mov ax, [eax+0x101c4780] */
            ii(0x1010_732d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_7330, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1010_7337, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_733b, 3); shl(eax, 0x8);                          /* shl eax, 0x8 */
            ii(0x1010_733e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7340, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_7343, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_7346, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7348, 6); mov(eax, memd_a32[ds, eax + 0x101c_4980]); /* mov eax, [eax+0x101c4980] */
            ii(0x1010_734e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_7351, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_7355, 6); mov(al, memb_a32[ds, eax + 0x101c_40b4]); /* mov al, [eax+0x101c40b4] */
            ii(0x1010_735b, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1010_735e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7360, 4); mov(ax, memw_a32[ss, ebp - 0x18]);      /* mov ax, [ebp-0x18] */
            ii(0x1010_7364, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x1010_7367, 5); cmp(eax, 0x400);                        /* cmp eax, 0x400 */
            ii(0x1010_736c, 2); if(jbed(0x1010_73a7, 0x39)) goto l_0x1010_73a7; /* jbe 0x101073a7 */
            ii(0x1010_736e, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_7373, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1010_7376, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_7379, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_737b, 4); mov(bx, memw_a32[ss, ebp - 0x1c]);      /* mov bx, [ebp-0x1c] */
            ii(0x1010_737f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_7383, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_7386, 6); mov(edx, memd_a32[ds, eax + 0x101c_4150]); /* mov edx, [eax+0x101c4150] */
            ii(0x1010_738c, 3); add(edx, memd_a32[ss, ebp - 0x20]);     /* add edx, [ebp-0x20] */
            ii(0x1010_738f, 6); lea(eax, ebp - 0x248);                  /* lea eax, [ebp-0x248] */
            ii(0x1010_7395, 5); calld(Definitions.sys_memcpy, 0x5eab1); /* call 0x10165e4b */
            ii(0x1010_739a, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1010_73a1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_73a4, 3); sub(memd_a32[ss, ebp - 0x18], eax);     /* sub [ebp-0x18], eax */
        l_0x1010_73a7:
            ii(0x1010_73a7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_73a9, 4); mov(bx, memw_a32[ss, ebp - 0x18]);      /* mov bx, [ebp-0x18] */
            ii(0x1010_73ad, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_73b1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_73b4, 6); mov(edx, memd_a32[ds, eax + 0x101c_4150]); /* mov edx, [eax+0x101c4150] */
            ii(0x1010_73ba, 3); add(edx, memd_a32[ss, ebp - 0x20]);     /* add edx, [ebp-0x20] */
            ii(0x1010_73bd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_73bf, 4); mov(ax, memw_a32[ss, ebp - 0x1c]);      /* mov ax, [ebp-0x1c] */
            ii(0x1010_73c3, 6); lea(ecx, ebp - 0x248);                  /* lea ecx, [ebp-0x248] */
            ii(0x1010_73c9, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_73cb, 5); calld(Definitions.sys_memcpy, 0x5ea7b); /* call 0x10165e4b */
            ii(0x1010_73d0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_73d4, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1010_73d7, 6); mov(memb_a32[ds, edx + 0x101c_40b4], al); /* mov [edx+0x101c40b4], al */
            ii(0x1010_73dd, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_73e2, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_73e6, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1010_73e9, 5); mov(ebx, 0x101c_4090);                  /* mov ebx, 0x101c4090 */
            ii(0x1010_73ee, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1010_73f0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_73f4, 3); shl(eax, 0x7);                          /* shl eax, 0x7 */
            ii(0x1010_73f7, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1010_73fa, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1010_73fc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_73fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7400, 7); mov(dx, memw_a32[ds, eax + 0x101c_4780]); /* mov dx, [eax+0x101c4780] */
            ii(0x1010_7407, 6); lea(eax, ebp - 0x248);                  /* lea eax, [ebp-0x248] */
            ii(0x1010_740d, 5); calld(0x1010_7e6a, 0xa58);              /* call 0x10107e6a */
            ii(0x1010_7412, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_7416, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1010_7419, 6); mov(memb_a32[ds, edx + 0x101c_40b4], al); /* mov [edx+0x101c40b4], al */
            ii(0x1010_741f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_7421, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_7424, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_7428, 5); calld(0x1010_7083, -0x3aa);             /* call 0x10107083 */
            ii(0x1010_742d, 2); jmpd(0x1010_743d, 0xe); goto l_0x1010_743d; /* jmp 0x1010743d */
        l_0x1010_742f:
            ii(0x1010_742f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_7431, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_7434, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_7438, 5); calld(0x1010_7083, -0x3ba);             /* call 0x10107083 */
        l_0x1010_743d:
            ii(0x1010_743d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_7440, 4); mov(memb_a32[ds, eax + 0x8], 0);        /* mov byte [eax+0x8], 0x0 */
        l_0x1010_7444:
            ii(0x1010_7444, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_7446, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_7447, 1); popd(edi);                              /* pop edi */
            ii(0x1010_7448, 1); popd(esi);                              /* pop esi */
            ii(0x1010_7449, 1); popd(edx);                              /* pop edx */
            ii(0x1010_744a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_744b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_744c, 1); retd(); return;                         /* ret */
        }
    }
}
