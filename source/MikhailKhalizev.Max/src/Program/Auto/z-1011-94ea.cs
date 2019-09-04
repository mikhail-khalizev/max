using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_94ea-6fe1dc36")]
        public void Method_1011_94ea()
        {
            ii(0x1011_94ea, 5); push(0x44);                             /* push 0x44 */
            ii(0x1011_94ef, 5); call(Definitions.sys_check_available_stack_size, 0x4_c85e); /* call 0x10165d52 */
            ii(0x1011_94f4, 1); push(esi);                              /* push esi */
            ii(0x1011_94f5, 1); push(edi);                              /* push edi */
            ii(0x1011_94f6, 1); push(ebp);                              /* push ebp */
            ii(0x1011_94f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_94f9, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1011_94ff, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1011_9502, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1011_9505, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_9508, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x1011_950b, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_950f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_9511, 6); mov(edx, memd[ds, eax + 0x101b_af9d]);  /* mov edx, [eax+0x101baf9d] */
            ii(0x1011_9517, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_951a, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_951d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_951f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_9522, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_9528, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1011_952c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_952e, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_9531, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_9535, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_9537, 6); mov(edx, memd[ds, eax + 0x101b_af9e]);  /* mov edx, [eax+0x101baf9e] */
            ii(0x1011_953d, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_9540, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_9543, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9545, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_9548, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_954e, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_9552, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_9554, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1011_9557, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_955b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_955d, 6); mov(edx, memd[ds, eax + 0x101b_afad]);  /* mov edx, [eax+0x101bafad] */
            ii(0x1011_9563, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_9566, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_9569, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_956b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_956e, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_9574, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1011_9578, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_957a, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1011_957d, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_9581, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_9583, 6); mov(edx, memd[ds, eax + 0x101b_afae]);  /* mov edx, [eax+0x101bafae] */
            ii(0x1011_9589, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_958c, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_958f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9591, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_9594, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_959a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_959c, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1011_95a0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_95a2, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1011_95a5, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1011_95a9, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1011_95ab, 6); mov(edx, memd[ds, edx + 0x101b_afbd]);  /* mov edx, [edx+0x101bafbd] */
            ii(0x1011_95b1, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_95b4, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_95b7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_95b9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_95bc, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_95c2, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1011_95c6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_95c8, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1011_95cb, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_95cf, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_95d1, 6); mov(edx, memd[ds, eax + 0x101b_afbe]);  /* mov edx, [eax+0x101bafbe] */
            ii(0x1011_95d7, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_95da, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_95dd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_95df, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_95e2, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_95e8, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_95ec, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_95ee, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1011_95f1, 6); mov(ebx, memd[ds, 0x101b_8746]);        /* mov ebx, [0x101b8746] */
            ii(0x1011_95f7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_95fa, 1); dec(ebx);                               /* dec ebx */
            ii(0x1011_95fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_95fd, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1011_9601, 5); call(0x1007_6e7c, -0xa_278a);           /* call 0x10076e7c */
            ii(0x1011_9606, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_9608, 5); call(Definitions.my_min, -0x8_fe89);    /* call 0x10089784 */
            ii(0x1011_960d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_9610, 6); mov(ebx, memd[ds, 0x101b_8748]);        /* mov ebx, [0x101b8748] */
            ii(0x1011_9616, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9619, 1); dec(ebx);                               /* dec ebx */
            ii(0x1011_961a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_961c, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1011_9620, 5); call(0x1007_6e7c, -0xa_27a9);           /* call 0x10076e7c */
            ii(0x1011_9625, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_9627, 5); call(Definitions.my_min, -0x8_fea8);    /* call 0x10089784 */
            ii(0x1011_962c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1011_962f, 6); mov(ebx, memd[ds, 0x101b_8746]);        /* mov ebx, [0x101b8746] */
            ii(0x1011_9635, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9638, 1); dec(ebx);                               /* dec ebx */
            ii(0x1011_9639, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_963b, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_963f, 5); call(0x1007_6e7c, -0xa_27c8);           /* call 0x10076e7c */
            ii(0x1011_9644, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_9646, 5); call(Definitions.my_min, -0x8_fec7);    /* call 0x10089784 */
            ii(0x1011_964b, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1011_964e, 5); mov(eax, memd[ds, 0x101b_8748]);        /* mov eax, [0x101b8748] */
            ii(0x1011_9653, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_9656, 3); lea(ebx, memd[ds, eax - 1]);            /* lea ebx, [eax-0x1] */
            ii(0x1011_9659, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_965b, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x1011_965f, 5); call(0x1007_6e7c, -0xa_27e8);           /* call 0x10076e7c */
            ii(0x1011_9664, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_9666, 5); call(Definitions.my_min, -0x8_fee7);    /* call 0x10089784 */
            ii(0x1011_966b, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1011_966e, 5); mov(eax, memd[ds, 0x101b_8746]);        /* mov eax, [0x101b8746] */
            ii(0x1011_9673, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_9676, 3); lea(ebx, memd[ds, eax - 1]);            /* lea ebx, [eax-0x1] */
            ii(0x1011_9679, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_967b, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x1011_967f, 5); call(0x1007_6e7c, -0xa_2808);           /* call 0x10076e7c */
            ii(0x1011_9684, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_9686, 5); call(Definitions.my_min, -0x8_ff07);    /* call 0x10089784 */
            ii(0x1011_968b, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1011_968e, 5); mov(eax, memd[ds, 0x101b_8748]);        /* mov eax, [0x101b8748] */
            ii(0x1011_9693, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_9696, 3); lea(ebx, memd[ds, eax - 1]);            /* lea ebx, [eax-0x1] */
            ii(0x1011_9699, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_969b, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x1011_969f, 5); call(0x1007_6e7c, -0xa_2828);           /* call 0x10076e7c */
            ii(0x1011_96a4, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1011_96a6, 5); call(Definitions.my_min, -0x8_ff27);    /* call 0x10089784 */
            ii(0x1011_96ab, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1011_96ae, 4); movsx(eax, memw[ss, ebp + 16]);         /* movsx eax, word [ebp+0x10] */
            ii(0x1011_96b2, 1); push(eax);                              /* push eax */
            ii(0x1011_96b3, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x1011_96b7, 1); push(eax);                              /* push eax */
            ii(0x1011_96b8, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_96bc, 1); push(eax);                              /* push eax */
            ii(0x1011_96bd, 4); movsx(ecx, memw[ss, ebp - 24]);         /* movsx ecx, word [ebp-0x18] */
            ii(0x1011_96c1, 4); movsx(ebx, memw[ss, ebp - 20]);         /* movsx ebx, word [ebp-0x14] */
            ii(0x1011_96c5, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1011_96c8, 3); mov(edx, memd[ds, edx + 14]);           /* mov edx, [edx+0xe] */
            ii(0x1011_96cb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_96ce, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_96d1, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_96d4, 5); call(/* sys */ 0x1016_a5a0, 0x5_0ec7);  /* call 0x1016a5a0 */
            ii(0x1011_96d9, 4); movsx(eax, memw[ss, ebp + 16]);         /* movsx eax, word [ebp+0x10] */
            ii(0x1011_96dd, 1); push(eax);                              /* push eax */
            ii(0x1011_96de, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x1011_96e2, 1); push(eax);                              /* push eax */
            ii(0x1011_96e3, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x1011_96e7, 1); push(eax);                              /* push eax */
            ii(0x1011_96e8, 4); movsx(ecx, memw[ss, ebp - 32]);         /* movsx ecx, word [ebp-0x20] */
            ii(0x1011_96ec, 4); movsx(ebx, memw[ss, ebp - 28]);         /* movsx ebx, word [ebp-0x1c] */
            ii(0x1011_96f0, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1011_96f3, 3); mov(edx, memd[ds, edx + 14]);           /* mov edx, [edx+0xe] */
            ii(0x1011_96f6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_96f9, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_96fc, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_96ff, 5); call(/* sys */ 0x1016_a5a0, 0x5_0e9c);  /* call 0x1016a5a0 */
            ii(0x1011_9704, 4); movsx(eax, memw[ss, ebp + 16]);         /* movsx eax, word [ebp+0x10] */
            ii(0x1011_9708, 1); push(eax);                              /* push eax */
            ii(0x1011_9709, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1011_970d, 1); push(eax);                              /* push eax */
            ii(0x1011_970e, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1011_9712, 1); push(eax);                              /* push eax */
            ii(0x1011_9713, 4); movsx(ecx, memw[ss, ebp - 40]);         /* movsx ecx, word [ebp-0x28] */
            ii(0x1011_9717, 4); movsx(ebx, memw[ss, ebp - 36]);         /* movsx ebx, word [ebp-0x24] */
            ii(0x1011_971b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_971e, 3); mov(edx, memd[ds, eax + 14]);           /* mov edx, [eax+0xe] */
            ii(0x1011_9721, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_9724, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_9727, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_972a, 5); call(/* sys */ 0x1016_a5a0, 0x5_0e71);  /* call 0x1016a5a0 */
            ii(0x1011_972f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9731, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_9732, 1); pop(edi);                               /* pop edi */
            ii(0x1011_9733, 1); pop(esi);                               /* pop esi */
            ii(0x1011_9734, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
