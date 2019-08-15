using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("52209789-f0d0-47ea-9704-392d29ccd48e")]
        public void Method_1012_7184()
        {
            ii(0x1012_7184, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1012_7189, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ebc4); /* call 0x10165d52 */
            ii(0x1012_718e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_718f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_7190, 1); pushd(edx);                             /* push edx */
            ii(0x1012_7191, 1); pushd(esi);                             /* push esi */
            ii(0x1012_7192, 1); pushd(edi);                             /* push edi */
            ii(0x1012_7193, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_7194, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_7196, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_719c, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x1e);   /* mov byte [0x101c5c1c], 0x1e */
            ii(0x1012_71a3, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x12f);  /* mov word [0x101c5c1f], 0x12f */
        l_0x1012_71ac:
            ii(0x1012_71ac, 5); calld(/* sys */ 0x1016_5e9b, 0x3_ecea); /* call 0x10165e9b */
            ii(0x1012_71b1, 6); imul(eax, eax, 0x7cf7);                 /* imul eax, eax, 0x7cf7 */
            ii(0x1012_71b7, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1012_71ba, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1012_71bd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_71c0, 4); mov(memb_a32[ss, ebp - 0x10], 0x4);     /* mov byte [ebp-0x10], 0x4 */
        l_0x1012_71c4:
            ii(0x1012_71c4, 3); dec(memb_a32[ss, ebp - 0x10]);          /* dec byte [ebp-0x10] */
            ii(0x1012_71c7, 4); cmp(memb_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp byte [ebp-0x10], 0xff */
            ii(0x1012_71cb, 2); if(jzd(0x1012_71f3, 0x26)) goto l_0x1012_71f3; /* jz 0x101271f3 */
            ii(0x1012_71cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_71cf, 3); mov(dl, memb_a32[ss, ebp - 0x10]);      /* mov dl, [ebp-0x10] */
            ii(0x1012_71d2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_71d4, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_71d6, 6); mov(edx, memd_a32[ds, 0x101c_59cc]);    /* mov edx, [0x101c59cc] */
            ii(0x1012_71dc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_71de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_71e1, 7); cmp(ax, memw_a32[ds, edx + 0x4dc]);     /* cmp ax, [edx+0x4dc] */
            ii(0x1012_71e8, 2); if(jnzd(0x1012_71f1, 0x7)) goto l_0x1012_71f1; /* jnz 0x101271f1 */
            ii(0x1012_71ea, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1012_71f1:
            ii(0x1012_71f1, 2); jmpd(0x1012_71c4, -0x2f); goto l_0x1012_71c4; /* jmp 0x101271c4 */
        l_0x1012_71f3:
            ii(0x1012_71f3, 5); cmp(memw_a32[ss, ebp - 0x8], 0);        /* cmp word [ebp-0x8], 0x0 */
            ii(0x1012_71f8, 2); if(jzd(0x1012_71ac, -0x4e)) goto l_0x1012_71ac; /* jz 0x101271ac */
            ii(0x1012_71fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_71fd, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_7203, 7); mov(memd_a32[ss, ebp - 0xc], 0x101c_5c21); /* mov dword [ebp-0xc], 0x101c5c21 */
            ii(0x1012_720a, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_720f, 4); mov(dx, memw_a32[ds, eax + 0x14]);      /* mov dx, [eax+0x14] */
            ii(0x1012_7213, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_7216, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1012_7219, 4); mov(memb_a32[ss, ebp - 0x4], 0x4);      /* mov byte [ebp-0x4], 0x4 */
        l_0x1012_721d:
            ii(0x1012_721d, 3); dec(memb_a32[ss, ebp - 0x4]);           /* dec byte [ebp-0x4] */
            ii(0x1012_7220, 4); cmp(memb_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp byte [ebp-0x4], 0xff */
            ii(0x1012_7224, 2); if(jzd(0x1012_7277, 0x51)) goto l_0x1012_7277; /* jz 0x10127277 */
            ii(0x1012_7226, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7228, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_722b, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1012_722e, 6); mov(edx, memd_a32[ds, 0x101c_59cc]);    /* mov edx, [0x101c59cc] */
            ii(0x1012_7234, 6); add(edx, 0x338);                        /* add edx, 0x338 */
            ii(0x1012_723a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_723c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_723e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_7241, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1012_7244, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1012_7247, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1012_724a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_724c, 5); calld(Definitions.sys_strcpy, 0x3_ec7e); /* call 0x10165ecf */
            ii(0x1012_7251, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7253, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_7256, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_7258, 6); mov(edx, memd_a32[ds, 0x101c_59cc]);    /* mov edx, [0x101c59cc] */
            ii(0x1012_725e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7260, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_7262, 3); mov(dl, memb_a32[ss, ebp - 0x4]);       /* mov dl, [ebp-0x4] */
            ii(0x1012_7265, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1012_7267, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1012_726a, 7); mov(ax, memw_a32[ds, eax + 0x4dc]);     /* mov ax, [eax+0x4dc] */
            ii(0x1012_7271, 4); mov(memw_a32[ds, edx + 0x7a], ax);      /* mov [edx+0x7a], ax */
            ii(0x1012_7275, 2); jmpd(0x1012_721d, -0x5a); goto l_0x1012_721d; /* jmp 0x1012721d */
        l_0x1012_7277:
            ii(0x1012_7277, 5); mov(ebx, 0xad);                         /* mov ebx, 0xad */
            ii(0x1012_727c, 6); mov(edx, memd_a32[ds, 0x101c_59cc]);    /* mov edx, [0x101c59cc] */
            ii(0x1012_7282, 6); add(edx, 0x4f0);                        /* add edx, 0x4f0 */
            ii(0x1012_7288, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_728b, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1012_7290, 5); calld(Definitions.sys_memcpy, 0x3_ebb6); /* call 0x10165e4b */
            ii(0x1012_7295, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7297, 5); calld(0x1012_5be9, -0x16b3);            /* call 0x10125be9 */
            ii(0x1012_729c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_729e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_729f, 1); popd(edi);                              /* pop edi */
            ii(0x1012_72a0, 1); popd(esi);                              /* pop esi */
            ii(0x1012_72a1, 1); popd(edx);                              /* pop edx */
            ii(0x1012_72a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_72a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_72a4, 1); retd(); return;                         /* ret */
        }
    }
}
