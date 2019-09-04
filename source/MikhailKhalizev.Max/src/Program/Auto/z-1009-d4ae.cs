using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d4ae-228193d1")]
        public void Method_1009_d4ae()
        {
            ii(0x1009_d4ae, 5); push(0x34);                             /* push 0x34 */
            ii(0x1009_d4b3, 5); call(Definitions.sys_check_available_stack_size, 0xc_889a); /* call 0x10165d52 */
            ii(0x1009_d4b8, 1); push(ebx);                              /* push ebx */
            ii(0x1009_d4b9, 1); push(ecx);                              /* push ecx */
            ii(0x1009_d4ba, 1); push(edx);                              /* push edx */
            ii(0x1009_d4bb, 1); push(esi);                              /* push esi */
            ii(0x1009_d4bc, 1); push(edi);                              /* push edi */
            ii(0x1009_d4bd, 1); push(ebp);                              /* push ebp */
            ii(0x1009_d4be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d4c0, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_d4c6, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_d4c9, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_d4cc, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_69e1); /* call 0x10076af0 */
            ii(0x1009_d4d1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d4d4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d4d7, 5); call(0x1007_6574, -0x2_6f68);           /* call 0x10076574 */
            ii(0x1009_d4dc, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1009_d4e0, 4); mov(memw[ss, ebp - 12], ax);            /* mov [ebp-0xc], ax */
            ii(0x1009_d4e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d4e7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d4ea, 5); call(0x1007_6574, -0x2_6f7b);           /* call 0x10076574 */
            ii(0x1009_d4ef, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1009_d4f3, 4); mov(memw[ss, ebp - 10], ax);            /* mov [ebp-0xa], ax */
        l_0x1009_d4f7:
            ii(0x1009_d4f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d4fa, 4); cmp(memb[ds, eax + 61], 0);             /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1009_d4fe, 6); if(jz(0x1009_d655, 0x151)) goto l_0x1009_d655; /* jz 0x1009d655 */
            ii(0x1009_d504, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d507, 4); mov(ax, memw[ds, eax + 53]);            /* mov ax, [eax+0x35] */
            ii(0x1009_d50b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d50e, 4); sub(ax, memw[ds, edx + 49]);            /* sub ax, [edx+0x31] */
            ii(0x1009_d512, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_d515, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d518, 4); mov(ax, memw[ds, eax + 51]);            /* mov ax, [eax+0x33] */
            ii(0x1009_d51c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d51f, 4); sub(ax, memw[ds, edx + 47]);            /* sub ax, [edx+0x2f] */
            ii(0x1009_d523, 1); cwde();                                 /* cwde */
            ii(0x1009_d524, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_d526, 5); call(0x1015_c339, 0xb_ee0e);            /* call 0x1015c339 */
            ii(0x1009_d52b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_d52e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1009_d532, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_d535, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_d53a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_d53c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d53f, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1009_d542, 5); call(0x1008_b1a4, -0x1_23a3);           /* call 0x1008b1a4 */
            ii(0x1009_d547, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d54a, 4); mov(dx, memw[ds, eax + 47]);            /* mov dx, [eax+0x2f] */
            ii(0x1009_d54e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d551, 4); cmp(dx, memw[ds, eax + 51]);            /* cmp dx, [eax+0x33] */
            ii(0x1009_d555, 2); if(jnz(0x1009_d567, 0x10)) goto l_0x1009_d567; /* jnz 0x1009d567 */
            ii(0x1009_d557, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d55a, 4); mov(dx, memw[ds, eax + 49]);            /* mov dx, [eax+0x31] */
            ii(0x1009_d55e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d561, 4); cmp(dx, memw[ds, eax + 53]);            /* cmp dx, [eax+0x35] */
            ii(0x1009_d565, 2); if(jz(0x1009_d569, 2)) goto l_0x1009_d569; /* jz 0x1009d569 */
        l_0x1009_d567:
            ii(0x1009_d567, 2); jmp(0x1009_d58f, 0x26); goto l_0x1009_d58f; /* jmp 0x1009d58f */
        l_0x1009_d569:
            ii(0x1009_d569, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d56c, 4); mov(dx, memw[ds, eax + 51]);            /* mov dx, [eax+0x33] */
            ii(0x1009_d570, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_d572, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d575, 3); sub(edx, memd[ss, ebp - 12]);           /* sub edx, [ebp-0xc] */
            ii(0x1009_d578, 4); mov(memw[ds, eax + 51], dx);            /* mov [eax+0x33], dx */
            ii(0x1009_d57c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d57f, 4); mov(dx, memw[ds, eax + 53]);            /* mov dx, [eax+0x35] */
            ii(0x1009_d583, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_d585, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d588, 3); sub(edx, memd[ss, ebp - 10]);           /* sub edx, [ebp-0xa] */
            ii(0x1009_d58b, 4); mov(memw[ds, eax + 53], dx);            /* mov [eax+0x35], dx */
        l_0x1009_d58f:
            ii(0x1009_d58f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d592, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1009_d595, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_d598, 5); call(0x1007_5e64, -0x2_7739);           /* call 0x10075e64 */
            ii(0x1009_d59d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_d59f, 3); lea(edx, memd[ss, ebp - 12]);           /* lea edx, [ebp-0xc] */
            ii(0x1009_d5a2, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1009_d5a5, 5); call(0x1007_5e64, -0x2_7746);           /* call 0x10075e64 */
            ii(0x1009_d5aa, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_d5ac, 5); call(0x100a_5fca, 0x8a19);              /* call 0x100a5fca */
            ii(0x1009_d5b1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_d5b4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_d5b6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_d5b9, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_d5bb, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1009_d5bd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d5c0, 4); mov(memw[ds, edx + 55], ax);            /* mov [edx+0x37], ax */
            ii(0x1009_d5c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d5c7, 4); mov(memb[ds, eax + 61], 1);             /* mov byte [eax+0x3d], 0x1 */
            ii(0x1009_d5cb, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d5ce, 4); mov(ax, memw[ds, edx + 55]);            /* mov ax, [edx+0x37] */
            ii(0x1009_d5d2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d5d5, 4); cmp(ax, memw[ds, edx + 57]);            /* cmp ax, [edx+0x39] */
            ii(0x1009_d5d9, 2); if(jz(0x1009_d650, 0x75)) goto l_0x1009_d650; /* jz 0x1009d650 */
            ii(0x1009_d5db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d5de, 4); mov(dx, memw[ds, eax + 55]);            /* mov dx, [eax+0x37] */
            ii(0x1009_d5e2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d5e5, 4); mov(memw[ds, eax + 57], dx);            /* mov [eax+0x39], dx */
            ii(0x1009_d5e9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d5ec, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1009_d5ef, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d5f2, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_d5f5, 5); call(0x1008_8b44, -0x1_4ab6);           /* call 0x10088b44 */
            ii(0x1009_d5fa, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_d5fd, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1009_d600, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d603, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x1009_d606, 5); call(0x1008_8b44, -0x1_4ac7);           /* call 0x10088b44 */
            ii(0x1009_d60b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_d60e, 3); add(edx, 2);                            /* add edx, 0x2 */
            ii(0x1009_d611, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d614, 3); and(edx, 7);                            /* and edx, 0x7 */
            ii(0x1009_d617, 4); mov(memw[ds, eax + 43], dx);            /* mov [eax+0x2b], dx */
            ii(0x1009_d61b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_d61e, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1009_d621, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d624, 3); and(edx, 7);                            /* and edx, 0x7 */
            ii(0x1009_d627, 4); mov(memw[ds, eax + 45], dx);            /* mov [eax+0x2d], dx */
            ii(0x1009_d62b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d62e, 6); mov(memw[ds, eax + 33], 0);             /* mov word [eax+0x21], 0x0 */
            ii(0x1009_d634, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d637, 6); mov(memw[ds, eax + 59], 1);             /* mov word [eax+0x3b], 0x1 */
            ii(0x1009_d63d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d640, 4); mov(memb[ds, eax + 61], 0);             /* mov byte [eax+0x3d], 0x0 */
            ii(0x1009_d644, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d647, 5); call(0x1009_d691, 0x45);                /* call 0x1009d691 */
            ii(0x1009_d64c, 2); test(al, al);                           /* test al, al */
            ii(0x1009_d64e, 2); if(jnz(0x1009_d688, 0x38)) goto l_0x1009_d688; /* jnz 0x1009d688 */
        l_0x1009_d650:
            ii(0x1009_d650, 5); jmp(0x1009_d4f7, -0x15e); goto l_0x1009_d4f7; /* jmp 0x1009d4f7 */
        l_0x1009_d655:
            ii(0x1009_d655, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d658, 4); cmp(memd[ds, eax + 27], 0);             /* cmp dword [eax+0x1b], 0x0 */
            ii(0x1009_d65c, 2); if(jz(0x1009_d680, 0x22)) goto l_0x1009_d680; /* jz 0x1009d680 */
            ii(0x1009_d65e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d661, 3); mov(eax, memd[ds, eax + 27]);           /* mov eax, [eax+0x1b] */
            ii(0x1009_d664, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1009_d667, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1009_d66a, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1009_d66d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d670, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d673, 5); call(0x1007_65d0, -0x2_70a8);           /* call 0x100765d0 */
            ii(0x1009_d678, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d67a, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1009_d67d, 3); call_abs(memd[ds, ebx + 112]);          /* call dword [ebx+0x70] */
        l_0x1009_d680:
            ii(0x1009_d680, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_d683, 5); call(0x1009_e31c, 0xc94);               /* call 0x1009e31c */
        l_0x1009_d688:
            ii(0x1009_d688, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d68a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_d68b, 1); pop(edi);                               /* pop edi */
            ii(0x1009_d68c, 1); pop(esi);                               /* pop esi */
            ii(0x1009_d68d, 1); pop(edx);                               /* pop edx */
            ii(0x1009_d68e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_d68f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_d690, 1); ret();                                  /* ret */
        }
    }
}
