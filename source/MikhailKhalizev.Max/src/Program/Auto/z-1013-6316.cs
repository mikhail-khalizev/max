using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6316-8636084d")]
        public void Method_1013_6316()
        {
            ii(0x1013_6316, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_631b, 5); call(Definitions.sys_check_available_stack_size, 0x2_fa32); /* call 0x10165d52 */
            ii(0x1013_6320, 1); push(ebx);                              /* push ebx */
            ii(0x1013_6321, 1); push(ecx);                              /* push ecx */
            ii(0x1013_6322, 1); push(edx);                              /* push edx */
            ii(0x1013_6323, 1); push(esi);                              /* push esi */
            ii(0x1013_6324, 1); push(edi);                              /* push edi */
            ii(0x1013_6325, 1); push(ebp);                              /* push ebp */
            ii(0x1013_6326, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6328, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_632e, 7); mov(memd[ss, ebp - 0x4], 0x5);          /* mov dword [ebp-0x4], 0x5 */
        l_0x1013_6335:
            ii(0x1013_6335, 3); dec(memd[ss, ebp - 0x4]);               /* dec dword [ebp-0x4] */
            ii(0x1013_6338, 5); cmp(memw[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1013_633d, 6); if(jz(0x1013_6480, 0x13d)) goto l_0x1013_6480; /* jz 0x10136480 */
            ii(0x1013_6343, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6347, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1013_634a, 5); mov(edx, 0x101c_35b4);                  /* mov edx, 0x101c35b4 */
            ii(0x1013_634f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_6351, 5); call(0x1009_caf8, -0x9_985e);           /* call 0x1009caf8 */
            ii(0x1013_6356, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6358, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_635c, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x1013_6362, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1013_6367, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_6369, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1013_636e, 5); call(0x1007_6630, -0xb_fd43);           /* call 0x10076630 */
            ii(0x1013_6373, 5); mov(ebx, 0x247);                        /* mov ebx, 0x247 */
            ii(0x1013_6378, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_637a, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_637e, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x1013_6384, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1013_6389, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_638b, 5); call(Definitions.sys_memset, 0x2_fa50); /* call 0x10165de0 */
            ii(0x1013_6390, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1013_6395, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1013_639a, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_639e, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x1013_63a4, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1013_63a9, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_63ab, 5); call(Definitions.sys_memset, 0x2_fa30); /* call 0x10165de0 */
            ii(0x1013_63b0, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x1013_63b5, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_63ba, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_63be, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_63c4, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x1013_63c9, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_63cb, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1013_63ce, 5); call(Definitions.sys_memset, 0x2_fa0d); /* call 0x10165de0 */
            ii(0x1013_63d3, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1013_63d8, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1013_63dd, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1013_63e1, 6); imul(ecx, ecx, 0x247);                  /* imul ecx, ecx, 0x247 */
            ii(0x1013_63e7, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1013_63ec, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_63ee, 5); add(eax, 0xee);                         /* add eax, 0xee */
            ii(0x1013_63f3, 5); call(Definitions.sys_memset, 0x2_f9e8); /* call 0x10165de0 */
            ii(0x1013_63f8, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1013_63fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_63ff, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6403, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_6409, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x1013_640e, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_6410, 5); add(eax, 0x11d);                        /* add eax, 0x11d */
            ii(0x1013_6415, 5); call(Definitions.sys_memset, 0x2_f9c6); /* call 0x10165de0 */
            ii(0x1013_641a, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x1013_641f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6421, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6425, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_642b, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x1013_6430, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_6432, 5); add(eax, 0x181);                        /* add eax, 0x181 */
            ii(0x1013_6437, 5); call(Definitions.sys_memset, 0x2_f9a4); /* call 0x10165de0 */
            ii(0x1013_643c, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_6440, 6); mov(eax, memd[ds, eax + 0x101b_873d]);  /* mov eax, [eax+0x101b873d] */
            ii(0x1013_6446, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_6449, 5); call(0x1007_5fdc, -0xc_0472);           /* call 0x10075fdc */
            ii(0x1013_644e, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_6452, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_6458, 6); mov(memb[ds, edx + 0x101c_a490], al);   /* mov [edx+0x101ca490], al */
            ii(0x1013_645e, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_6461, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1013_6463, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_6466, 5); call(0x1007_5fdc, -0xc_048f);           /* call 0x10075fdc */
            ii(0x1013_646b, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_646f, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_6475, 6); mov(memb[ds, edx + 0x101c_a4ef], al);   /* mov [edx+0x101ca4ef], al */
            ii(0x1013_647b, 5); jmp(0x1013_6335, -0x14b); goto l_0x1013_6335; /* jmp 0x10136335 */
        l_0x1013_6480:
            ii(0x1013_6480, 5); mov(eax, 0x101c_61b4);                  /* mov eax, 0x101c61b4 */
            ii(0x1013_6485, 5); call(0x1013_65a4, 0x11a);               /* call 0x101365a4 */
            ii(0x1013_648a, 5); mov(eax, 0x101c_64b0);                  /* mov eax, 0x101c64b0 */
            ii(0x1013_648f, 5); call(0x1013_65a4, 0x110);               /* call 0x101365a4 */
            ii(0x1013_6494, 5); mov(eax, 0x101c_67ac);                  /* mov eax, 0x101c67ac */
            ii(0x1013_6499, 5); call(0x1013_65a4, 0x106);               /* call 0x101365a4 */
            ii(0x1013_649e, 5); mov(eax, 0x101c_6aa8);                  /* mov eax, 0x101c6aa8 */
            ii(0x1013_64a3, 5); call(0x1013_65a4, 0xfc);                /* call 0x101365a4 */
            ii(0x1013_64a8, 5); mov(eax, 0x101c_6da4);                  /* mov eax, 0x101c6da4 */
            ii(0x1013_64ad, 5); call(0x1013_65a4, 0xf2);                /* call 0x101365a4 */
            ii(0x1013_64b2, 10); mov(memd[ds, 0x101c_a562], 0x101c_61b4); /* mov dword [0x101ca562], 0x101c61b4 */
            ii(0x1013_64bc, 10); mov(memd[ds, 0x101c_a7a9], 0x101c_64b0); /* mov dword [0x101ca7a9], 0x101c64b0 */
            ii(0x1013_64c6, 10); mov(memd[ds, 0x101c_a9f0], 0x101c_67ac); /* mov dword [0x101ca9f0], 0x101c67ac */
            ii(0x1013_64d0, 10); mov(memd[ds, 0x101c_ac37], 0x101c_6aa8); /* mov dword [0x101cac37], 0x101c6aa8 */
            ii(0x1013_64da, 10); mov(memd[ds, 0x101c_ae7e], 0x101c_6da4); /* mov dword [0x101cae7e], 0x101c6da4 */
            ii(0x1013_64e4, 5); call(0x1011_7afb, -0x1_e9ee);           /* call 0x10117afb */
            ii(0x1013_64e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_64eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_64ec, 1); pop(edi);                               /* pop edi */
            ii(0x1013_64ed, 1); pop(esi);                               /* pop esi */
            ii(0x1013_64ee, 1); pop(edx);                               /* pop edx */
            ii(0x1013_64ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_64f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_64f1, 1); ret();                                  /* ret */
        }
    }
}
