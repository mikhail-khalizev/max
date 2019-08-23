using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_686a-1f3ef0b6")]
        public void Method_1012_686a()
        {
            ii(0x1012_686a, 5); push(0x40);                             /* push 0x40 */
            ii(0x1012_686f, 5); call(Definitions.sys_check_available_stack_size, 0x3_f4de); /* call 0x10165d52 */
            ii(0x1012_6874, 1); push(ebx);                              /* push ebx */
            ii(0x1012_6875, 1); push(ecx);                              /* push ecx */
            ii(0x1012_6876, 1); push(edx);                              /* push edx */
            ii(0x1012_6877, 1); push(esi);                              /* push esi */
            ii(0x1012_6878, 1); push(edi);                              /* push edi */
            ii(0x1012_6879, 1); push(ebp);                              /* push ebp */
            ii(0x1012_687a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_687c, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1012_6882, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_6885, 7); mov(memd[ss, ebp - 0xc], 0x101c_59f5);  /* mov dword [ebp-0xc], 0x101c59f5 */
            ii(0x1012_688c, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1012_6890, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_6893, 5); call(Definitions.my_ctor_0x101b_38d0, -0xb_0054); /* call 0x10076844 */
            ii(0x1012_6898, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_689b, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1012_689f, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1012_68a4, 5); call(Definitions.sys_new, 0x3_f557);    /* call 0x10165e00 */
            ii(0x1012_68a9, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_68ac, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_68af, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_68b2, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1012_68b6, 2); if(jz(0x1012_68eb, 0x33)) goto l_0x1012_68eb; /* jz 0x101268eb */
            ii(0x1012_68b8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_68bb, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_68be, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_68c2, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_68c8, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1012_68cd, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_68cf, 5); call(0x100d_fd2c, -0x4_6ba8);           /* call 0x100dfd2c */
            ii(0x1012_68d4, 3); mov(ebx, memd[ss, ebp - 0x18]);         /* mov ebx, [ebp-0x18] */
            ii(0x1012_68d7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_68d9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_68db, 5); call(0x100c_a2f8, -0x5_c5e8);           /* call 0x100ca2f8 */
            ii(0x1012_68e0, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_68e3, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_68e6, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_68e9, 2); jmp(0x1012_68f1, 0x6); goto l_0x1012_68f1; /* jmp 0x101268f1 */
        l_0x1012_68eb:
            ii(0x1012_68eb, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_68ee, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1012_68f1:
            ii(0x1012_68f1, 3); mov(edx, memd[ss, ebp - 0x24]);         /* mov edx, [ebp-0x24] */
            ii(0x1012_68f4, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_68f7, 5); call(0x100c_b77c, -0x5_b180);           /* call 0x100cb77c */
            ii(0x1012_68fc, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_68ff, 5); call(0x1007_6730, -0xb_01d4);           /* call 0x10076730 */
            ii(0x1012_6904, 5); call(0x100c_b7e4, -0x5_b125);           /* call 0x100cb7e4 */
            ii(0x1012_6909, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_690b, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_690e, 5); call(0x1007_6730, -0xb_01e3);           /* call 0x10076730 */
            ii(0x1012_6913, 5); call(0x100c_b7b4, -0x5_b164);           /* call 0x100cb7b4 */
            ii(0x1012_6918, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_691b, 5); call(0x1007_6730, -0xb_01f0);           /* call 0x10076730 */
            ii(0x1012_6920, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6923, 4); mov(dx, memw[ds, edx + 0x2]);           /* mov dx, [edx+0x2] */
            ii(0x1012_6927, 4); mov(memw[ds, eax + 0x8], dx);           /* mov [eax+0x8], dx */
            ii(0x1012_692b, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_692e, 5); call(0x1007_6730, -0xb_0203);           /* call 0x10076730 */
            ii(0x1012_6933, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6936, 4); mov(dx, memw[ds, edx + 0x4]);           /* mov dx, [edx+0x4] */
            ii(0x1012_693a, 4); mov(memw[ds, eax + 0xa], dx);           /* mov [eax+0xa], dx */
            ii(0x1012_693e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_6941, 5); call(0x1007_6730, -0xb_0216);           /* call 0x10076730 */
            ii(0x1012_6946, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6949, 4); mov(dx, memw[ds, edx + 0x6]);           /* mov dx, [edx+0x6] */
            ii(0x1012_694d, 4); mov(memw[ds, eax + 0xc], dx);           /* mov [eax+0xc], dx */
            ii(0x1012_6951, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_6954, 5); call(0x1007_6730, -0xb_0229);           /* call 0x10076730 */
            ii(0x1012_6959, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_695c, 4); mov(dx, memw[ds, edx + 0x8]);           /* mov dx, [edx+0x8] */
            ii(0x1012_6960, 4); mov(memw[ds, eax + 0xe], dx);           /* mov [eax+0xe], dx */
            ii(0x1012_6964, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_6967, 5); call(0x1007_6730, -0xb_023c);           /* call 0x10076730 */
            ii(0x1012_696c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_696f, 4); mov(dx, memw[ds, edx + 0xa]);           /* mov dx, [edx+0xa] */
            ii(0x1012_6973, 4); mov(memw[ds, eax + 0x10], dx);          /* mov [eax+0x10], dx */
            ii(0x1012_6977, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_697a, 5); call(0x1007_6730, -0xb_024f);           /* call 0x10076730 */
            ii(0x1012_697f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6982, 4); mov(dx, memw[ds, edx + 0xc]);           /* mov dx, [edx+0xc] */
            ii(0x1012_6986, 4); mov(memw[ds, eax + 0x12], dx);          /* mov [eax+0x12], dx */
            ii(0x1012_698a, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_698d, 5); call(0x1007_6730, -0xb_0262);           /* call 0x10076730 */
            ii(0x1012_6992, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6995, 4); mov(dx, memw[ds, edx + 0xe]);           /* mov dx, [edx+0xe] */
            ii(0x1012_6999, 4); mov(memw[ds, eax + 0x14], dx);          /* mov [eax+0x14], dx */
            ii(0x1012_699d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_69a0, 5); call(0x1007_6730, -0xb_0275);           /* call 0x10076730 */
            ii(0x1012_69a5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_69a8, 3); mov(dl, memb[ds, edx + 0x10]);          /* mov dl, [edx+0x10] */
            ii(0x1012_69ab, 3); mov(memb[ds, eax + 0x16], dl);          /* mov [eax+0x16], dl */
            ii(0x1012_69ae, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_69b1, 5); call(0x1007_6730, -0xb_0286);           /* call 0x10076730 */
            ii(0x1012_69b6, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_69b9, 4); mov(dx, memw[ds, edx + 0x12]);          /* mov dx, [edx+0x12] */
            ii(0x1012_69bd, 4); mov(memw[ds, eax + 0x17], dx);          /* mov [eax+0x17], dx */
            ii(0x1012_69c1, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_69c4, 5); call(0x1007_6730, -0xb_0299);           /* call 0x10076730 */
            ii(0x1012_69c9, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_69cc, 4); mov(dx, memw[ds, edx + 0x14]);          /* mov dx, [edx+0x14] */
            ii(0x1012_69d0, 4); mov(memw[ds, eax + 0x19], dx);          /* mov [eax+0x19], dx */
            ii(0x1012_69d4, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_69d7, 5); call(0x1007_6730, -0xb_02ac);           /* call 0x10076730 */
            ii(0x1012_69dc, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_69df, 4); mov(dx, memw[ds, edx + 0x16]);          /* mov dx, [edx+0x16] */
            ii(0x1012_69e3, 4); mov(memw[ds, eax + 0x1b], dx);          /* mov [eax+0x1b], dx */
            ii(0x1012_69e7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_69ea, 5); call(0x1007_6730, -0xb_02bf);           /* call 0x10076730 */
            ii(0x1012_69ef, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_69f2, 4); mov(dx, memw[ds, edx + 0x18]);          /* mov dx, [edx+0x18] */
            ii(0x1012_69f6, 4); mov(memw[ds, eax + 0x1d], dx);          /* mov [eax+0x1d], dx */
            ii(0x1012_69fa, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_69fd, 5); call(0x1007_6730, -0xb_02d2);           /* call 0x10076730 */
            ii(0x1012_6a02, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6a05, 4); mov(dx, memw[ds, edx + 0x1a]);          /* mov dx, [edx+0x1a] */
            ii(0x1012_6a09, 4); mov(memw[ds, eax + 0x1f], dx);          /* mov [eax+0x1f], dx */
            ii(0x1012_6a0d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_6a10, 5); call(0x1007_678c, -0xb_0289);           /* call 0x1007678c */
            ii(0x1012_6a15, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_6a18, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x1012_6a1b, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1012_6a1f, 6); imul(ecx, ecx, 0x247);                  /* imul ecx, ecx, 0x247 */
            ii(0x1012_6a25, 6); mov(ecx, memd[ds, ecx + 0x101c_a562]);  /* mov ecx, [ecx+0x101ca562] */
            ii(0x1012_6a2b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_6a2d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1012_6a2f, 5); call(0x100c_b63c, -0x5_b3f8);           /* call 0x100cb63c */
            ii(0x1012_6a34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6a36, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1012_6a39, 5); call(0x1007_5eec, -0xb_0b52);           /* call 0x10075eec */
            ii(0x1012_6a3e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6a40, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_6a41, 1); pop(edi);                               /* pop edi */
            ii(0x1012_6a42, 1); pop(esi);                               /* pop esi */
            ii(0x1012_6a43, 1); pop(edx);                               /* pop edx */
            ii(0x1012_6a44, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_6a45, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_6a46, 1); ret();                                  /* ret */
        }
    }
}
