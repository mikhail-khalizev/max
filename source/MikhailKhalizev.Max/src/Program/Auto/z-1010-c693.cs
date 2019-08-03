using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c9021874-be3f-48e2-9435-e03212c67992")]
        public void Method_1010_c693()
        {
            ii(0x1010_c693, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1010_c698, 5); calld(Definitions.sys_check_available_stack_size, 0x596b5); /* call 0x10165d52 */
            ii(0x1010_c69d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_c69e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_c69f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_c6a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_c6a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_c6a3, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1010_c6a9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_c6ac, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_c6af, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1010_c6b2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c6b5, 5); calld(0x1010_9688, -0x3032);            /* call 0x10109688 */
            ii(0x1010_c6ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c6bd, 7); cmp(ax, memw_a32[ds, 0x101c_4e4e]);     /* cmp ax, [0x101c4e4e] */
            ii(0x1010_c6c4, 2); if(jnzd(0x1010_c6d1, 0xb)) goto l_0x1010_c6d1; /* jnz 0x1010c6d1 */
            ii(0x1010_c6c6, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_c6cb, 6); if(jnzd(0x1010_c752, 0x81)) goto l_0x1010_c752; /* jnz 0x1010c752 */
        l_0x1010_c6d1:
            ii(0x1010_c6d1, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_c6d6, 2); if(jzd(0x1010_c6e4, 0xc)) goto l_0x1010_c6e4; /* jz 0x1010c6e4 */
            ii(0x1010_c6d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c6db, 7); cmp(ax, memw_a32[ds, 0x101c_4e4e]);     /* cmp ax, [0x101c4e4e] */
            ii(0x1010_c6e2, 2); if(jnzd(0x1010_c6e6, 0x2)) goto l_0x1010_c6e6; /* jnz 0x1010c6e6 */
        l_0x1010_c6e4:
            ii(0x1010_c6e4, 2); jmpd(0x1010_c6ee, 0x8); goto l_0x1010_c6ee; /* jmp 0x1010c6ee */
        l_0x1010_c6e6:
            ii(0x1010_c6e6, 6); cmp(memw_a32[ss, ebp - 0x8], 0x6f7);    /* cmp word [ebp-0x8], 0x6f7 */
            ii(0x1010_c6ec, 2); if(jnzd(0x1010_c6f0, 0x2)) goto l_0x1010_c6f0; /* jnz 0x1010c6f0 */
        l_0x1010_c6ee:
            ii(0x1010_c6ee, 2); jmpd(0x1010_c6f8, 0x8); goto l_0x1010_c6f8; /* jmp 0x1010c6f8 */
        l_0x1010_c6f0:
            ii(0x1010_c6f0, 6); cmp(memw_a32[ss, ebp - 0x8], 0x705);    /* cmp word [ebp-0x8], 0x705 */
            ii(0x1010_c6f6, 2); if(jnzd(0x1010_c6fa, 0x2)) goto l_0x1010_c6fa; /* jnz 0x1010c6fa */
        l_0x1010_c6f8:
            ii(0x1010_c6f8, 2); jmpd(0x1010_c702, 0x8); goto l_0x1010_c702; /* jmp 0x1010c702 */
        l_0x1010_c6fa:
            ii(0x1010_c6fa, 6); cmp(memw_a32[ss, ebp - 0x8], 0x70a);    /* cmp word [ebp-0x8], 0x70a */
            ii(0x1010_c700, 2); if(jnzd(0x1010_c704, 0x2)) goto l_0x1010_c704; /* jnz 0x1010c704 */
        l_0x1010_c702:
            ii(0x1010_c702, 2); jmpd(0x1010_c70c, 0x8); goto l_0x1010_c70c; /* jmp 0x1010c70c */
        l_0x1010_c704:
            ii(0x1010_c704, 6); cmp(memw_a32[ss, ebp - 0x8], 0x716);    /* cmp word [ebp-0x8], 0x716 */
            ii(0x1010_c70a, 2); if(jnzd(0x1010_c70e, 0x2)) goto l_0x1010_c70e; /* jnz 0x1010c70e */
        l_0x1010_c70c:
            ii(0x1010_c70c, 2); jmpd(0x1010_c716, 0x8); goto l_0x1010_c716; /* jmp 0x1010c716 */
        l_0x1010_c70e:
            ii(0x1010_c70e, 6); cmp(memw_a32[ss, ebp - 0x8], 0x736);    /* cmp word [ebp-0x8], 0x736 */
            ii(0x1010_c714, 2); if(jnzd(0x1010_c718, 0x2)) goto l_0x1010_c718; /* jnz 0x1010c718 */
        l_0x1010_c716:
            ii(0x1010_c716, 2); jmpd(0x1010_c720, 0x8); goto l_0x1010_c720; /* jmp 0x1010c720 */
        l_0x1010_c718:
            ii(0x1010_c718, 6); cmp(memw_a32[ss, ebp - 0x8], 0x737);    /* cmp word [ebp-0x8], 0x737 */
            ii(0x1010_c71e, 2); if(jnzd(0x1010_c722, 0x2)) goto l_0x1010_c722; /* jnz 0x1010c722 */
        l_0x1010_c720:
            ii(0x1010_c720, 2); jmpd(0x1010_c72a, 0x8); goto l_0x1010_c72a; /* jmp 0x1010c72a */
        l_0x1010_c722:
            ii(0x1010_c722, 6); cmp(memw_a32[ss, ebp - 0x8], 0x738);    /* cmp word [ebp-0x8], 0x738 */
            ii(0x1010_c728, 2); if(jnzd(0x1010_c72c, 0x2)) goto l_0x1010_c72c; /* jnz 0x1010c72c */
        l_0x1010_c72a:
            ii(0x1010_c72a, 2); jmpd(0x1010_c734, 0x8); goto l_0x1010_c734; /* jmp 0x1010c734 */
        l_0x1010_c72c:
            ii(0x1010_c72c, 6); cmp(memw_a32[ss, ebp - 0x8], 0x739);    /* cmp word [ebp-0x8], 0x739 */
            ii(0x1010_c732, 2); if(jnzd(0x1010_c749, 0x15)) goto l_0x1010_c749; /* jnz 0x1010c749 */
        l_0x1010_c734:
            ii(0x1010_c734, 5); calld(/* sys */ 0x1016_5e9b, 0x59762);  /* call 0x10165e9b */
            ii(0x1010_c739, 3); imul(eax, eax, 0x43);                   /* imul eax, eax, 0x43 */
            ii(0x1010_c73c, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1010_c73f, 5); add(eax, 0x6f3);                        /* add eax, 0x6f3 */
            ii(0x1010_c744, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_c747, 2); jmpd(0x1010_c6d1, -0x78); goto l_0x1010_c6d1; /* jmp 0x1010c6d1 */
        l_0x1010_c749:
            ii(0x1010_c749, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c74c, 6); mov(memw_a32[ds, 0x101c_4e4e], ax);     /* mov [0x101c4e4e], ax */
        l_0x1010_c752:
            ii(0x1010_c752, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c755, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1010_c758, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c75b, 6); imul(edx, eax, 0xb6);                   /* imul edx, eax, 0xb6 */
            ii(0x1010_c761, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c764, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_c767, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1010_c76a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_c76c, 3); mov(memd_a32[ss, ebp - 0x12], eax);     /* mov [ebp-0x12], eax */
            ii(0x1010_c76f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c772, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1010_c776, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1010_c77a, 7); mov(memd_a32[ss, ebp - 0x28], 0x10);    /* mov dword [ebp-0x28], 0x10 */
            ii(0x1010_c781, 7); mov(memd_a32[ss, ebp - 0x24], 0xb6);    /* mov dword [ebp-0x24], 0xb6 */
            ii(0x1010_c788, 7); mov(memd_a32[ss, ebp - 0x20], 0x13c);   /* mov dword [ebp-0x20], 0x13c */
            ii(0x1010_c78f, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1a6);   /* mov dword [ebp-0x1c], 0x1a6 */
            ii(0x1010_c796, 5); calld(0x100d_533c, -0x3745f);           /* call 0x100d533c */
            ii(0x1010_c79b, 1); cwde();                                 /* cwde */
            ii(0x1010_c79c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c79d, 5); calld(0x100d_5360, -0x37442);           /* call 0x100d5360 */
            ii(0x1010_c7a2, 1); cwde();                                 /* cwde */
            ii(0x1010_c7a3, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c7a4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_c7a6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c7a7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_c7a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c7ac, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1010_c7af, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_c7b2, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1010_c7b5, 5); mov(eax, memd_a32[ds, 0x101c_4e4c]);    /* mov eax, [0x101c4e4c] */
            ii(0x1010_c7ba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c7bd, 5); calld(0x100e_8c51, -0x23b71);           /* call 0x100e8c51 */
            ii(0x1010_c7c2, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_c7c6, 2); if(jzd(0x1010_c7d6, 0xe)) goto l_0x1010_c7d6; /* jz 0x1010c7d6 */
            ii(0x1010_c7c8, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1010_c7cb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c7ce, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_c7d1, 5); calld(Definitions.sys_display_draw_1, 0x5acd2); /* call 0x101674a8 */
        l_0x1010_c7d6:
            ii(0x1010_c7d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_c7d8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_c7d9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_c7da, 1); popd(esi);                              /* pop esi */
            ii(0x1010_c7db, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_c7dc, 1); retd(); return;                         /* ret */
        }
    }
}
