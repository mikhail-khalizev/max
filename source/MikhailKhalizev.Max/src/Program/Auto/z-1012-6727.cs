using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_6727-4c7da528")]
        public void Method_1012_6727()
        {
            ii(0x1012_6727, 5); push(0x34);                             /* push 0x34 */
            ii(0x1012_672c, 5); call(Definitions.sys_check_available_stack_size, 0x3_f621); /* call 0x10165d52 */
            ii(0x1012_6731, 1); push(ebx);                              /* push ebx */
            ii(0x1012_6732, 1); push(ecx);                              /* push ecx */
            ii(0x1012_6733, 1); push(esi);                              /* push esi */
            ii(0x1012_6734, 1); push(edi);                              /* push edi */
            ii(0x1012_6735, 1); push(ebp);                              /* push ebp */
            ii(0x1012_6736, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_6738, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_673e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_6741, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1012_6744, 7); mov(memd[ss, ebp - 0xc], 0x101c_59f5);  /* mov dword [ebp-0xc], 0x101c59f5 */
            ii(0x1012_674b, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_674f, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1012_6752, 5); mov(edx, 0x101c_35b4);                  /* mov edx, 0x101c35b4 */
            ii(0x1012_6757, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_6759, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1012_675c, 5); call(0x1009_cb74, -0x8_9bed);           /* call 0x1009cb74 */
            ii(0x1012_6761, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_6763, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_6765, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_6768, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_676b, 5); call(0x1009_cab0, -0x8_9cc0);           /* call 0x1009cab0 */
            ii(0x1012_6770, 5); call(0x100e_0a00, -0x4_5d75);           /* call 0x100e0a00 */
            ii(0x1012_6775, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_6777, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_6779, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_677c, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_677f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6782, 5); call(0x100e_0970, -0x4_5e17);           /* call 0x100e0970 */
            ii(0x1012_6787, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_678a, 5); call(0x1009_caf8, -0x8_9c97);           /* call 0x1009caf8 */
            ii(0x1012_678f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6792, 5); call(0x100c_aac8, -0x5_bccf);           /* call 0x100caac8 */
            ii(0x1012_6797, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_679b, 2); if(jz(0x1012_67b6, 0x19)) goto l_0x1012_67b6; /* jz 0x101267b6 */
            ii(0x1012_679d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_679f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_67a2, 5); call(0x100e_0244, -0x4_6563);           /* call 0x100e0244 */
            ii(0x1012_67a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_67a9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_67ac, 5); call(0x1008_8b04, -0x9_dcad);           /* call 0x10088b04 */
            ii(0x1012_67b1, 5); jmp(0x1012_6862, 0xac); goto l_0x1012_6862; /* jmp 0x10126862 */
        l_0x1012_67b6:
            ii(0x1012_67b6, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_67bd, 2); jmp(0x1012_67c5, 0x6); goto l_0x1012_67c5; /* jmp 0x101267c5 */
        l_0x1012_67bf:
            ii(0x1012_67bf, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_67c2, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x1012_67c5:
            ii(0x1012_67c5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_67c8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_67cb, 4); cmp(ax, memw[ds, edx + 0x4]);           /* cmp ax, [edx+0x4] */
            ii(0x1012_67cf, 2); if(jge(0x1012_6804, 0x33)) goto l_0x1012_6804; /* jge 0x10126804 */
            ii(0x1012_67d1, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1012_67d5, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_67d8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_67db, 3); add(eax, 0xd);                          /* add eax, 0xd */
            ii(0x1012_67de, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_67e0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_67e3, 5); call(0x1008_b2a8, -0x9_b540);           /* call 0x1008b2a8 */
            ii(0x1012_67e8, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_67ec, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_67ef, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_67f2, 3); add(edx, 0xd);                          /* add edx, 0xd */
            ii(0x1012_67f5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_67f7, 3); lea(edx, eax + 0x2);                    /* lea edx, [eax+0x2] */
            ii(0x1012_67fa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_67fd, 5); call(0x100c_aa44, -0x5_bdbe);           /* call 0x100caa44 */
            ii(0x1012_6802, 2); jmp(0x1012_67bf, -0x45); goto l_0x1012_67bf; /* jmp 0x101267bf */
        l_0x1012_6804:
            ii(0x1012_6804, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_6807, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_680a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_680d, 3); mov(memd[ds, eax + 0xc], edx);          /* mov [eax+0xc], edx */
            ii(0x1012_6810, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_6813, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1012_6817, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_681a, 4); mov(memw[ds, eax + 0x10], dx);          /* mov [eax+0x10], dx */
            ii(0x1012_681e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_6821, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x1012_6824, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_6827, 3); mov(memd[ds, eax + 0x8], edx);          /* mov [eax+0x8], edx */
            ii(0x1012_682a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_682d, 3); mov(dl, memb[ds, eax + 0xc]);           /* mov dl, [eax+0xc] */
            ii(0x1012_6830, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_6833, 3); mov(memb[ds, eax + 0x12], dl);          /* mov [eax+0x12], dl */
            ii(0x1012_6836, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1012_683a, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1012_6840, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_6843, 4); mov(ax, memw[ds, eax + 0x6]);           /* mov ax, [eax+0x6] */
            ii(0x1012_6847, 7); mov(memw[ds, edx + 0x101c_a583], ax);   /* mov [edx+0x101ca583], ax */
            ii(0x1012_684e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6850, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6853, 5); call(0x100e_0244, -0x4_6614);           /* call 0x100e0244 */
            ii(0x1012_6858, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_685a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_685d, 5); call(0x1008_8b04, -0x9_dd5e);           /* call 0x10088b04 */
        l_0x1012_6862:
            ii(0x1012_6862, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6864, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_6865, 1); pop(edi);                               /* pop edi */
            ii(0x1012_6866, 1); pop(esi);                               /* pop esi */
            ii(0x1012_6867, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_6868, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_6869, 1); ret();                                  /* ret */
        }
    }
}
