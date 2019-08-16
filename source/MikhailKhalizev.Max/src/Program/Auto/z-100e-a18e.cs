using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e247632c-48a2-4e95-9abf-02859664cc0a")]
        public void Method_100e_a18e()
        {
            ii(0x100e_a18e, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100e_a193, 5); calld(Definitions.sys_check_available_stack_size, 0x7_bbba); /* call 0x10165d52 */
            ii(0x100e_a198, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a199, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a19a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a19b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a19d, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100e_a1a3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a1a6, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_a1a9, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_a1ac, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100e_a1af, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x100e_a1b3, 3); lea(edi, ebp - 0x24);                   /* lea edi, [ebp-0x24] */
            ii(0x100e_a1b6, 3); mov(esi, memd_a32[ss, ebp - 0xc]);      /* mov esi, [ebp-0xc] */
            ii(0x100e_a1b9, 2); movsw_a32();                            /* movsw */
            ii(0x100e_a1bb, 1); movsb_a32();                            /* movsb */
            ii(0x100e_a1bc, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a1c0, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100e_a1c3, 2); if(jnzd(0x100e_a1cb, 0x6)) goto l_0x100e_a1cb; /* jnz 0x100ea1cb */
            ii(0x100e_a1c5, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100e_a1c9, 2); jmpd(0x100e_a1cf, 0x4); goto l_0x100e_a1cf; /* jmp 0x100ea1cf */
        l_0x100e_a1cb:
            ii(0x100e_a1cb, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100e_a1cf:
            ii(0x100e_a1cf, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100e_a1d2, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
        l_0x100e_a1d5:
            ii(0x100e_a1d5, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x100e_a1d9, 6); if(jnzd(0x100e_a2c0, 0xe1)) goto l_0x100e_a2c0; /* jnz 0x100ea2c0 */
            ii(0x100e_a1df, 4); cmp(memb_a32[ss, ebp - 0x1c], 0);       /* cmp byte [ebp-0x1c], 0x0 */
            ii(0x100e_a1e3, 2); if(jnzd(0x100e_a21f, 0x3a)) goto l_0x100e_a21f; /* jnz 0x100ea21f */
            ii(0x100e_a1e5, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100e_a1ea, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100e_a1ed, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a1f0, 5); calld(0x100e_a11c, -0xd9);              /* call 0x100ea11c */
            ii(0x100e_a1f5, 4); movsx(edx, memb_a32[ss, ebp - 0x23]);   /* movsx edx, byte [ebp-0x23] */
            ii(0x100e_a1f9, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100e_a1fb, 3); add(edx, memd_a32[ss, ebp + 0x10]);     /* add edx, [ebp+0x10] */
            ii(0x100e_a1fe, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100e_a201, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x100e_a206, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100e_a209, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a20c, 5); calld(0x100e_a11c, -0xf5);              /* call 0x100ea11c */
            ii(0x100e_a211, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_a213, 4); movsx(eax, memb_a32[ss, ebp - 0x23]);   /* movsx eax, byte [ebp-0x23] */
            ii(0x100e_a217, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a219, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100e_a21c, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
        l_0x100e_a21f:
            ii(0x100e_a21f, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
            ii(0x100e_a223, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_a226, 3); add(memb_a32[ss, ebp - 0x23], al);      /* add [ebp-0x23], al */
            ii(0x100e_a229, 4); movsx(eax, memb_a32[ss, ebp - 0x23]);   /* movsx eax, byte [ebp-0x23] */
            ii(0x100e_a22d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_a22f, 2); if(jld(0x100e_a23a, 0x9)) goto l_0x100e_a23a; /* jl 0x100ea23a */
            ii(0x100e_a231, 4); movsx(eax, memb_a32[ss, ebp - 0x23]);   /* movsx eax, byte [ebp-0x23] */
            ii(0x100e_a235, 3); cmp(eax, 0x1f);                         /* cmp eax, 0x1f */
            ii(0x100e_a238, 2); if(jled(0x100e_a243, 0x9)) goto l_0x100e_a243; /* jle 0x100ea243 */
        l_0x100e_a23a:
            ii(0x100e_a23a, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x100e_a23e, 5); jmpd(0x100e_a2bb, 0x78); goto l_0x100e_a2bb; /* jmp 0x100ea2bb */
        l_0x100e_a243:
            ii(0x100e_a243, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100e_a246, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a249, 5); calld(0x100e_a067, -0x1e7);             /* call 0x100ea067 */
            ii(0x100e_a24e, 2); test(al, al);                           /* test al, al */
            ii(0x100e_a250, 2); if(jnzd(0x100e_a2bb, 0x69)) goto l_0x100e_a2bb; /* jnz 0x100ea2bb */
            ii(0x100e_a252, 4); movsx(eax, memb_a32[ss, ebp - 0x23]);   /* movsx eax, byte [ebp-0x23] */
            ii(0x100e_a256, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_a25a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_a25c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a25e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100e_a261, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_a263, 3); mov(memb_a32[ss, ebp - 0x22], al);      /* mov [ebp-0x22], al */
        l_0x100e_a266:
            ii(0x100e_a266, 4); movsx(edx, memb_a32[ss, ebp - 0x23]);   /* movsx edx, byte [ebp-0x23] */
            ii(0x100e_a26a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a26e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_a270, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a272, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a274, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x100e_a277, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_a27a, 4); movsx(edx, memb_a32[ss, ebp - 0x22]);   /* movsx edx, byte [ebp-0x22] */
            ii(0x100e_a27e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_a280, 2); if(jgd(0x100e_a291, 0xf)) goto l_0x100e_a291; /* jg 0x100ea291 */
            ii(0x100e_a282, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100e_a285, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a288, 5); calld(0x100e_a067, -0x226);             /* call 0x100ea067 */
            ii(0x100e_a28d, 2); test(al, al);                           /* test al, al */
            ii(0x100e_a28f, 2); if(jzd(0x100e_a293, 0x2)) goto l_0x100e_a293; /* jz 0x100ea293 */
        l_0x100e_a291:
            ii(0x100e_a291, 2); jmpd(0x100e_a29b, 0x8); goto l_0x100e_a29b; /* jmp 0x100ea29b */
        l_0x100e_a293:
            ii(0x100e_a293, 3); mov(al, memb_a32[ss, ebp - 0x22]);      /* mov al, [ebp-0x22] */
            ii(0x100e_a296, 3); inc(memb_a32[ss, ebp - 0x22]);          /* inc byte [ebp-0x22] */
            ii(0x100e_a299, 2); jmpd(0x100e_a266, -0x35); goto l_0x100e_a266; /* jmp 0x100ea266 */
        l_0x100e_a29b:
            ii(0x100e_a29b, 4); movsx(edx, memb_a32[ss, ebp - 0x23]);   /* movsx edx, byte [ebp-0x23] */
            ii(0x100e_a29f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a2a3, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_a2a5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_a2a7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a2a9, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x100e_a2ac, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_a2af, 4); movsx(edx, memb_a32[ss, ebp - 0x22]);   /* movsx edx, byte [ebp-0x22] */
            ii(0x100e_a2b3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_a2b5, 2); if(jled(0x100e_a2bb, 0x4)) goto l_0x100e_a2bb; /* jle 0x100ea2bb */
            ii(0x100e_a2b7, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
        l_0x100e_a2bb:
            ii(0x100e_a2bb, 5); jmpd(0x100e_a1d5, -0xeb); goto l_0x100e_a1d5; /* jmp 0x100ea1d5 */
        l_0x100e_a2c0:
            ii(0x100e_a2c0, 5); movsx(ax, memb_a32[ss, ebp - 0x23]);    /* movsx ax, byte [ebp-0x23] */
            ii(0x100e_a2c5, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x100e_a2c8, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_a2cb, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_a2ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a2d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a2d1, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a2d2, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a2d3, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}