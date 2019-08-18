using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_e49e-f366ac65")]
        public void Method_1013_e49e()
        {
            ii(0x1013_e49e, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1013_e4a3, 5); calld(Definitions.sys_check_available_stack_size, 0x2_78aa); /* call 0x10165d52 */
            ii(0x1013_e4a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_e4a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_e4aa, 1); pushd(edx);                             /* push edx */
            ii(0x1013_e4ab, 1); pushd(esi);                             /* push esi */
            ii(0x1013_e4ac, 1); pushd(edi);                             /* push edi */
            ii(0x1013_e4ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_e4ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_e4b0, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_e4b6, 10); cmp(memd_a32[ds, 0x101c_7294], 0xffff); /* cmp dword [0x101c7294], 0xffff */
            ii(0x1013_e4c0, 6); if(jzd(0x1013_e765, 0x29f)) goto l_0x1013_e765; /* jz 0x1013e765 */
            ii(0x1013_e4c6, 7); cmp(memb_a32[ds, 0x101c_728e], 0);      /* cmp byte [0x101c728e], 0x0 */
            ii(0x1013_e4cd, 6); if(jzd(0x1013_e5fe, 0x12b)) goto l_0x1013_e5fe; /* jz 0x1013e5fe */
            ii(0x1013_e4d3, 7); mov(memb_a32[ds, 0x101c_728e], 0);      /* mov byte [0x101c728e], 0x0 */
        l_0x1013_e4da:
            ii(0x1013_e4da, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e4dc, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_e4e1, 6); mov(al, memb_a32[ds, eax + 0x101c_8078]); /* mov al, [eax+0x101c8078] */
            ii(0x1013_e4e7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_e4ec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e4ee, 6); if(jnzd(0x1013_e5a7, 0xb3)) goto l_0x1013_e5a7; /* jnz 0x1013e5a7 */
            ii(0x1013_e4f4, 7); cmp(memd_a32[ds, 0x101c_8046], 0);      /* cmp dword [0x101c8046], 0x0 */
            ii(0x1013_e4fb, 2); if(jnzd(0x1013_e507, 0xa)) goto l_0x1013_e507; /* jnz 0x1013e507 */
            ii(0x1013_e4fd, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_e502, 5); calld(0x1013_e341, -0x1c6);             /* call 0x1013e341 */
        l_0x1013_e507:
            ii(0x1013_e507, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e509, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_e50e, 6); imul(edx, eax, 0x6e00);                 /* imul edx, eax, 0x6e00 */
            ii(0x1013_e514, 5); mov(eax, memd_a32[ds, 0x101c_728a]);    /* mov eax, [0x101c728a] */
            ii(0x1013_e519, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_e51b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_e51e, 6); mov(edx, memd_a32[ds, 0x101c_8046]);    /* mov edx, [0x101c8046] */
            ii(0x1013_e524, 5); mov(eax, 0x6e00);                       /* mov eax, 0x6e00 */
            ii(0x1013_e529, 5); calld(Definitions.my_min, -0xb_4daa);   /* call 0x10089784 */
            ii(0x1013_e52e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_e531, 6); mov(ecx, memd_a32[ds, 0x101c_7280]);    /* mov ecx, [0x101c7280] */
            ii(0x1013_e537, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1013_e53a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_e53f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_e542, 5); calld(Definitions.sys_fread, 0x3_4025); /* call 0x1017256c */
            ii(0x1013_e547, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_e54a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_e54d, 6); sub(memd_a32[ds, 0x101c_8046], eax);    /* sub [0x101c8046], eax */
            ii(0x1013_e553, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e555, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_e55a, 7); mov(memb_a32[ds, eax + 0x101c_8078], 0x1); /* mov byte [eax+0x101c8078], 0x1 */
            ii(0x1013_e561, 6); inc(memb_a32[ds, 0x101c_8081]);         /* inc byte [0x101c8081] */
            ii(0x1013_e567, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e569, 5); mov(al, memb_a32[ds, 0x101c_8081]);     /* mov al, [0x101c8081] */
            ii(0x1013_e56e, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_e571, 2); if(jld(0x1013_e57a, 0x7)) goto l_0x1013_e57a; /* jl 0x1013e57a */
            ii(0x1013_e573, 7); mov(memb_a32[ds, 0x101c_8081], 0);      /* mov byte [0x101c8081], 0x0 */
        l_0x1013_e57a:
            ii(0x1013_e57a, 7); cmp(memd_a32[ds, 0x101c_8046], 0);      /* cmp dword [0x101c8046], 0x0 */
            ii(0x1013_e581, 2); if(jgd(0x1013_e5a2, 0x1f)) goto l_0x1013_e5a2; /* jg 0x1013e5a2 */
            ii(0x1013_e583, 5); mov(ebx, 0x6e00);                       /* mov ebx, 0x6e00 */
            ii(0x1013_e588, 3); sub(ebx, memd_a32[ss, ebp - 0x18]);     /* sub ebx, [ebp-0x18] */
            ii(0x1013_e58b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_e58d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_e590, 3); add(eax, memd_a32[ss, ebp - 0x18]);     /* add eax, [ebp-0x18] */
            ii(0x1013_e593, 5); calld(Definitions.sys_memset, 0x2_7848); /* call 0x10165de0 */
            ii(0x1013_e598, 10); mov(memd_a32[ds, 0x101c_8046], 0);     /* mov dword [0x101c8046], 0x0 */
        l_0x1013_e5a2:
            ii(0x1013_e5a2, 5); jmpd(0x1013_e4da, -0xcd); goto l_0x1013_e4da; /* jmp 0x1013e4da */
        l_0x1013_e5a7:
            ii(0x1013_e5a7, 7); cmp(memb_a32[ds, 0x101c_728f], 0);      /* cmp byte [0x101c728f], 0x0 */
            ii(0x1013_e5ae, 2); if(jzd(0x1013_e5fe, 0x4e)) goto l_0x1013_e5fe; /* jz 0x1013e5fe */
            ii(0x1013_e5b0, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_e5b2, 6); mov(edx, memd_a32[ds, 0x101c_728a]);    /* mov edx, [0x101c728a] */
            ii(0x1013_e5b8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_e5ba, 6); mov(cl, memb_a32[ds, 0x101c_8082]);     /* mov cl, [0x101c8082] */
            ii(0x1013_e5c0, 6); imul(ecx, ecx, 0x6e00);                 /* imul ecx, ecx, 0x6e00 */
            ii(0x1013_e5c6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_e5c8, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1013_e5ca, 5); mov(eax, memd_a32[ds, 0x101c_7278]);    /* mov eax, [0x101c7278] */
            ii(0x1013_e5cf, 4); mov(memw_a32[ds, eax + 0xf], bx);       /* mov [eax+0xf], bx */
            ii(0x1013_e5d3, 3); mov(memd_a32[ds, eax + 0xb], ecx);      /* mov [eax+0xb], ecx */
            ii(0x1013_e5d6, 5); mov(eax, memd_a32[ds, 0x101c_7278]);    /* mov eax, [0x101c7278] */
            ii(0x1013_e5db, 3); add(eax, 0xb);                          /* add eax, 0xb */
            ii(0x1013_e5de, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1013_e5e0, 6); mov(edx, memd_a32[ds, 0x101c_7290]);    /* mov edx, [0x101c7290] */
            ii(0x1013_e5e6, 6); mov(esi, memd_a32[ds, 0x101c_7294]);    /* mov esi, [0x101c7294] */
            ii(0x1013_e5ec, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1013_e5ee, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_e5f0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1013_e5f2, 5); calld(/* sys */ 0x1018_03dc, 0x4_1de5); /* call 0x101803dc */
            ii(0x1013_e5f7, 7); mov(memb_a32[ds, 0x101c_728f], 0);      /* mov byte [0x101c728f], 0x0 */
        l_0x1013_e5fe:
            ii(0x1013_e5fe, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_e605, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1013_e609, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1013_e60d, 2); jmpd(0x1013_e615, 0x6); goto l_0x1013_e615; /* jmp 0x1013e615 */
        l_0x1013_e60f:
            ii(0x1013_e60f, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_e612, 3); inc(memb_a32[ss, ebp - 0x8]);           /* inc byte [ebp-0x8] */
        l_0x1013_e615:
            ii(0x1013_e615, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_e618, 6); cmp(al, memb_a32[ds, 0x101c_7298]);     /* cmp al, [0x101c7298] */
            ii(0x1013_e61e, 6); if(jaed(0x1013_e696, 0x72)) goto l_0x1013_e696; /* jae 0x1013e696 */
            ii(0x1013_e624, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e626, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_e629, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_e62c, 5); mov(edx, 0x101c_7299);                  /* mov edx, 0x101c7299 */
            ii(0x1013_e631, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_e633, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1013_e636, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_e63a, 2); if(jzd(0x1013_e645, 0x9)) goto l_0x1013_e645; /* jz 0x1013e645 */
            ii(0x1013_e63c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_e63f, 4); cmp(memb_a32[ds, eax + 0xa], 0x3);      /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_e643, 2); if(jzd(0x1013_e656, 0x11)) goto l_0x1013_e656; /* jz 0x1013e656 */
        l_0x1013_e645:
            ii(0x1013_e645, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1013_e648, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_e64d, 5); calld(0x1013_e76e, 0x11c);              /* call 0x1013e76e */
            ii(0x1013_e652, 2); cmp(al, 0xb);                           /* cmp al, 0xb */
            ii(0x1013_e654, 2); if(jnzd(0x1013_e691, 0x3b)) goto l_0x1013_e691; /* jnz 0x1013e691 */
        l_0x1013_e656:
            ii(0x1013_e656, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_e65a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e65c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_e65f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_e661, 2); if(jzd(0x1013_e67e, 0x1b)) goto l_0x1013_e67e; /* jz 0x1013e67e */
            ii(0x1013_e663, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1013_e668, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1013_e66b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_e66f, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_e672, 5); mov(ecx, 0x101c_7299);                  /* mov ecx, 0x101c7299 */
            ii(0x1013_e677, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_e679, 5); calld(Definitions.sys_memcpy, 0x2_77cd); /* call 0x10165e4b */
        l_0x1013_e67e:
            ii(0x1013_e67e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_e681, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1013_e684, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_e687, 4); cmp(memb_a32[ds, eax + 0xa], 0x3);      /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_e68b, 2); if(jnzd(0x1013_e691, 0x4)) goto l_0x1013_e691; /* jnz 0x1013e691 */
            ii(0x1013_e68d, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
        l_0x1013_e691:
            ii(0x1013_e691, 5); jmpd(0x1013_e60f, -0x87); goto l_0x1013_e60f; /* jmp 0x1013e60f */
        l_0x1013_e696:
            ii(0x1013_e696, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1013_e699, 5); mov(memb_a32[ds, 0x101c_7298], al);     /* mov [0x101c7298], al */
            ii(0x1013_e69e, 4); mov(memb_a32[ss, ebp - 0x8], 0x14);     /* mov byte [ebp-0x8], 0x14 */
        l_0x1013_e6a2:
            ii(0x1013_e6a2, 3); dec(memb_a32[ss, ebp - 0x8]);           /* dec byte [ebp-0x8] */
            ii(0x1013_e6a5, 4); cmp(memb_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp byte [ebp-0x8], 0xff */
            ii(0x1013_e6a9, 6); if(jzd(0x1013_e765, 0xb6)) goto l_0x1013_e765; /* jz 0x1013e765 */
            ii(0x1013_e6af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e6b1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_e6b4, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_e6ba, 5); mov(edx, 0x101c_74c9);                  /* mov edx, 0x101c74c9 */
            ii(0x1013_e6bf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_e6c1, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1013_e6c4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e6c7, 6); cmp(memd_a32[ds, eax], 0xffff);         /* cmp dword [eax], 0xffff */
            ii(0x1013_e6cd, 2); if(jzd(0x1013_e6db, 0xc)) goto l_0x1013_e6db; /* jz 0x1013e6db */
            ii(0x1013_e6cf, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e6d2, 7); cmp(memd_a32[ds, eax + 0x8b], 0);       /* cmp dword [eax+0x8b], 0x0 */
            ii(0x1013_e6d9, 2); if(jnzd(0x1013_e6e0, 0x5)) goto l_0x1013_e6e0; /* jnz 0x1013e6e0 */
        l_0x1013_e6db:
            ii(0x1013_e6db, 5); jmpd(0x1013_e760, 0x80); goto l_0x1013_e760; /* jmp 0x1013e760 */
        l_0x1013_e6e0:
            ii(0x1013_e6e0, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e6e3, 6); mov(eax, memd_a32[ds, eax + 0x8b]);     /* mov eax, [eax+0x8b] */
            ii(0x1013_e6e9, 5); calld(0x1014_85ad, 0x9ebf);             /* call 0x101485ad */
            ii(0x1013_e6ee, 3); cmp(eax, 0x7d);                         /* cmp eax, 0x7d */
            ii(0x1013_e6f1, 2); if(jbed(0x1013_e760, 0x6d)) goto l_0x1013_e760; /* jbe 0x1013e760 */
            ii(0x1013_e6f3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e6f6, 6); shr(memd_a32[ds, eax + 0x83], 0x1);     /* shr dword [eax+0x83], 1 */
            ii(0x1013_e6fc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e6ff, 7); cmp(memd_a32[ds, eax + 0x83], 0);       /* cmp dword [eax+0x83], 0x0 */
            ii(0x1013_e706, 2); if(jzd(0x1013_e753, 0x4b)) goto l_0x1013_e753; /* jz 0x1013e753 */
            ii(0x1013_e708, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e70b, 3); shr(memd_a32[ds, eax + 0x7f], 0x1);     /* shr dword [eax+0x7f], 1 */
            ii(0x1013_e70e, 5); mov(eax, 0x37);                         /* mov eax, 0x37 */
            ii(0x1013_e713, 5); calld(0x1007_5fdc, -0xc_873c);          /* call 0x10075fdc */
            ii(0x1013_e718, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_e71a, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e71d, 3); mov(eax, memd_a32[ds, eax + 0x7f]);     /* mov eax, [eax+0x7f] */
            ii(0x1013_e720, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1013_e723, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1013_e728, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_e72a, 2); div(ebx);                               /* div ebx */
            ii(0x1013_e72c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_e72f, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x1013_e732, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e735, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1013_e737, 5); mov(eax, memd_a32[ds, 0x101c_7294]);    /* mov eax, [0x101c7294] */
            ii(0x1013_e73c, 5); calld(/* sys */ 0x1018_07a7, 0x4_2066); /* call 0x101807a7 */
            ii(0x1013_e741, 5); calld(0x1014_82f4, 0x9bae);             /* call 0x101482f4 */
            ii(0x1013_e746, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_e748, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_e74b, 6); mov(memd_a32[ds, eax + 0x8b], edx);     /* mov [eax+0x8b], edx */
            ii(0x1013_e751, 2); jmpd(0x1013_e760, 0xd); goto l_0x1013_e760; /* jmp 0x1013e760 */
        l_0x1013_e753:
            ii(0x1013_e753, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_e756, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_e75b, 5); calld(0x1013_ce3f, -0x1921);            /* call 0x1013ce3f */
        l_0x1013_e760:
            ii(0x1013_e760, 5); jmpd(0x1013_e6a2, -0xc3); goto l_0x1013_e6a2; /* jmp 0x1013e6a2 */
        l_0x1013_e765:
            ii(0x1013_e765, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_e767, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_e768, 1); popd(edi);                              /* pop edi */
            ii(0x1013_e769, 1); popd(esi);                              /* pop esi */
            ii(0x1013_e76a, 1); popd(edx);                              /* pop edx */
            ii(0x1013_e76b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_e76c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_e76d, 1); retd(); return;                         /* ret */
        }
    }
}
