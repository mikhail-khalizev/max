using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_497a-80a0d0e5")]
        public void Method_1009_497a()
        {
            ii(0x1009_497a, 5); push(0x70);                             /* push 0x70 */
            ii(0x1009_497f, 5); call(Definitions.sys_check_available_stack_size, 0xd_13ce); /* call 0x10165d52 */
            ii(0x1009_4984, 1); push(ebx);                              /* push ebx */
            ii(0x1009_4985, 1); push(ecx);                              /* push ecx */
            ii(0x1009_4986, 1); push(edx);                              /* push edx */
            ii(0x1009_4987, 1); push(esi);                              /* push esi */
            ii(0x1009_4988, 1); push(edi);                              /* push edi */
            ii(0x1009_4989, 1); push(ebp);                              /* push ebp */
            ii(0x1009_498a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_498c, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1009_4992, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_4995, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1009_499a, 5); call(0x1007_6338, -0x1_e667);           /* call 0x10076338 */
            ii(0x1009_499f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_49a1, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_49a4, 5); call(0x1007_64b8, -0x1_e4f1);           /* call 0x100764b8 */
            ii(0x1009_49a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_49ac, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1009_49af, 5); call(0x1007_20e6, -0x2_28ce);           /* call 0x100720e6 */
            ii(0x1009_49b4, 2); jmp(0x1009_49be, 8); goto l_0x1009_49be; /* jmp 0x100949be */
        l_0x1009_49b6:
            ii(0x1009_49b6, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_49b9, 5); call(0x1007_6bf8, -0x1_ddc6);           /* call 0x10076bf8 */
        l_0x1009_49be:
            ii(0x1009_49be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_49c0, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_49c3, 5); call(0x1013_ad71, 0xa_63a9);            /* call 0x1013ad71 */
            ii(0x1009_49c8, 2); test(al, al);                           /* test al, al */
            ii(0x1009_49ca, 6); if(jz(0x1009_4a45, 0x75)) goto l_0x1009_4a45; /* jz 0x10094a45 */
            ii(0x1009_49d0, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_49d3, 5); call(0x1007_63a0, -0x1_e638);           /* call 0x100763a0 */
            ii(0x1009_49d8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_49da, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1009_49dd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_49e0, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1009_49e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_49e6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_49e8, 2); if(jnz(0x1009_4a0a, 0x20)) goto l_0x1009_4a0a; /* jnz 0x10094a0a */
            ii(0x1009_49ea, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_49ed, 5); call(0x1007_63a0, -0x1_e652);           /* call 0x100763a0 */
            ii(0x1009_49f2, 5); cmp(memw[ds, eax + 8], 0x3d);           /* cmp word [eax+0x8], 0x3d */
            ii(0x1009_49f7, 2); if(jz(0x1009_4a08, 0xf)) goto l_0x1009_4a08; /* jz 0x10094a08 */
            ii(0x1009_49f9, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_49fc, 5); call(0x1007_63a0, -0x1_e661);           /* call 0x100763a0 */
            ii(0x1009_4a01, 5); cmp(memw[ds, eax + 8], 0x31);           /* cmp word [eax+0x8], 0x31 */
            ii(0x1009_4a06, 2); if(jnz(0x1009_4a0a, 2)) goto l_0x1009_4a0a; /* jnz 0x10094a0a */
        l_0x1009_4a08:
            ii(0x1009_4a08, 2); jmp(0x1009_4a0c, 2); goto l_0x1009_4a0c; /* jmp 0x10094a0c */
        l_0x1009_4a0a:
            ii(0x1009_4a0a, 2); jmp(0x1009_4a40, 0x34); goto l_0x1009_4a40; /* jmp 0x10094a40 */
        l_0x1009_4a0c:
            ii(0x1009_4a0c, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4a0f, 5); call(0x1007_63a0, -0x1_e674);           /* call 0x100763a0 */
            ii(0x1009_4a14, 4); mov(dx, memw[ds, eax + 82]);            /* mov dx, [eax+0x52] */
            ii(0x1009_4a18, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4a1b, 4); add(memw[ds, eax + 45], dx);            /* add [eax+0x2d], dx */
            ii(0x1009_4a1f, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4a22, 5); call(0x1007_63a0, -0x1_e687);           /* call 0x100763a0 */
            ii(0x1009_4a27, 5); cmp(memw[ds, eax + 8], 0x3d);           /* cmp word [eax+0x8], 0x3d */
            ii(0x1009_4a2c, 2); if(jnz(0x1009_4a38, 0xa)) goto l_0x1009_4a38; /* jnz 0x10094a38 */
            ii(0x1009_4a2e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4a31, 5); sub(memw[ds, eax + 45], 0x14);          /* sub word [eax+0x2d], 0x14 */
            ii(0x1009_4a36, 2); jmp(0x1009_4a40, 8); goto l_0x1009_4a40; /* jmp 0x10094a40 */
        l_0x1009_4a38:
            ii(0x1009_4a38, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4a3b, 5); sub(memw[ds, eax + 45], 0x28);          /* sub word [eax+0x2d], 0x28 */
        l_0x1009_4a40:
            ii(0x1009_4a40, 5); jmp(0x1009_49b6, -0x8f); goto l_0x1009_49b6; /* jmp 0x100949b6 */
        l_0x1009_4a45:
            ii(0x1009_4a45, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4a48, 3); mov(edx, memd[ds, eax + 43]);           /* mov edx, [eax+0x2b] */
            ii(0x1009_4a4b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4a4e, 3); sub(edx, 0x32);                         /* sub edx, 0x32 */
            ii(0x1009_4a51, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1009_4a56, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4a58, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4a5b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_4a5d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4a60, 4); mov(memw[ds, edx + 45], ax);            /* mov [edx+0x2d], ax */
            ii(0x1009_4a64, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4a67, 5); sub(memw[ds, eax + 47], 5);             /* sub word [eax+0x2f], 0x5 */
            ii(0x1009_4a6c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4a6e, 5); call(0x100c_dec2, 0x3_944f);            /* call 0x100cdec2 */
            ii(0x1009_4a73, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_4a75, 2); if(jz(0x1009_4a87, 0x10)) goto l_0x1009_4a87; /* jz 0x10094a87 */
            ii(0x1009_4a77, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4a79, 5); call(0x1007_2073, -0x2_2a0b);           /* call 0x10072073 */
            ii(0x1009_4a7e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4a80, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4a83, 4); sub(memw[ds, eax + 43], dx);            /* sub [eax+0x2b], dx */
        l_0x1009_4a87:
            ii(0x1009_4a87, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_4a8c, 5); call(0x1007_6338, -0x1_e759);           /* call 0x10076338 */
            ii(0x1009_4a91, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x1009_4a94, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4a96, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_4a98, 5); call(0x1007_643c, -0x1_e661);           /* call 0x1007643c */
            ii(0x1009_4a9d, 2); jmp(0x1009_4aa7, 8); goto l_0x1009_4aa7; /* jmp 0x10094aa7 */
        l_0x1009_4a9f:
            ii(0x1009_4a9f, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4aa2, 5); call(0x1007_6bf8, -0x1_deaf);           /* call 0x10076bf8 */
        l_0x1009_4aa7:
            ii(0x1009_4aa7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4aa9, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4aac, 5); call(0x1013_ad71, 0xa_62c0);            /* call 0x1013ad71 */
            ii(0x1009_4ab1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4ab3, 6); if(jz(0x1009_4c09, 0x150)) goto l_0x1009_4c09; /* jz 0x10094c09 */
            ii(0x1009_4ab9, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4abc, 5); call(0x1007_63a0, -0x1_e721);           /* call 0x100763a0 */
            ii(0x1009_4ac1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4ac3, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1009_4ac6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4ac9, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1009_4acc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4acf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_4ad1, 6); if(jnz(0x1009_4c04, 0x12d)) goto l_0x1009_4c04; /* jnz 0x10094c04 */
            ii(0x1009_4ad7, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1009_4adc, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4adf, 5); call(0x1007_63a0, -0x1_e744);           /* call 0x100763a0 */
            ii(0x1009_4ae4, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1009_4ae7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4aea, 5); call(0x1007_1e00, -0x2_2cef);           /* call 0x10071e00 */
            ii(0x1009_4aef, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4af1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4af4, 4); sub(memw[ds, eax + 45], dx);            /* sub [eax+0x2d], dx */
            ii(0x1009_4af8, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4afb, 5); call(0x1007_63a0, -0x1_e760);           /* call 0x100763a0 */
            ii(0x1009_4b00, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1009_4b03, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4b06, 5); call(0x1007_1ec5, -0x2_2c46);           /* call 0x10071ec5 */
            ii(0x1009_4b0b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4b0d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4b10, 4); sub(memw[ds, eax + 47], dx);            /* sub [eax+0x2f], dx */
            ii(0x1009_4b14, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4b17, 5); call(0x1007_63a0, -0x1_e77c);           /* call 0x100763a0 */
            ii(0x1009_4b1c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1009_4b1f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4b22, 5); call(0x1007_2073, -0x2_2ab4);           /* call 0x10072073 */
            ii(0x1009_4b27, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4b29, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4b2c, 4); sub(memw[ds, eax + 43], dx);            /* sub [eax+0x2b], dx */
            ii(0x1009_4b30, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4b33, 5); call(0x1007_63a0, -0x1_e798);           /* call 0x100763a0 */
            ii(0x1009_4b38, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1009_4b3b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4b3e, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_4b41, 6); mov(al, memb[ds, eax + 0x101c_81d5]);   /* mov al, [eax+0x101c81d5] */
            ii(0x1009_4b47, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
            ii(0x1009_4b4a, 5); jmp(0x1009_4bde, 0x8f); goto l_0x1009_4bde; /* jmp 0x10094bde */
        l_0x1009_4b4f:
            ii(0x1009_4b4f, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4b52, 5); call(0x1007_63a0, -0x1_e7b7);           /* call 0x100763a0 */
            ii(0x1009_4b57, 3); mov(edx, memd[ds, eax + 80]);           /* mov edx, [eax+0x50] */
            ii(0x1009_4b5a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4b5d, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1009_4b62, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4b64, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4b67, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_4b69, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4b6c, 3); mov(edx, memd[ds, edx + 43]);           /* mov edx, [edx+0x2b] */
            ii(0x1009_4b6f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4b72, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_4b74, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4b77, 4); mov(memw[ds, eax + 45], dx);            /* mov [eax+0x2d], dx */
            ii(0x1009_4b7b, 5); jmp(0x1009_4c04, 0x84); goto l_0x1009_4c04; /* jmp 0x10094c04 */
        l_0x1009_4b80:
            ii(0x1009_4b80, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4b83, 5); call(0x1007_63a0, -0x1_e7e8);           /* call 0x100763a0 */
            ii(0x1009_4b88, 3); mov(edx, memd[ds, eax + 80]);           /* mov edx, [eax+0x50] */
            ii(0x1009_4b8b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4b8e, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1009_4b93, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4b95, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4b98, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_4b9a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4b9d, 3); mov(edx, memd[ds, edx + 45]);           /* mov edx, [edx+0x2d] */
            ii(0x1009_4ba0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4ba3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_4ba5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4ba8, 4); mov(memw[ds, eax + 47], dx);            /* mov [eax+0x2f], dx */
            ii(0x1009_4bac, 2); jmp(0x1009_4c04, 0x56); goto l_0x1009_4c04; /* jmp 0x10094c04 */
        l_0x1009_4bae:
            ii(0x1009_4bae, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4bb1, 5); call(0x1007_63a0, -0x1_e816);           /* call 0x100763a0 */
            ii(0x1009_4bb6, 3); mov(edx, memd[ds, eax + 80]);           /* mov edx, [eax+0x50] */
            ii(0x1009_4bb9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4bbc, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x1009_4bc1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4bc3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4bc6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1009_4bc8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4bcb, 3); mov(edx, memd[ds, edx + 41]);           /* mov edx, [edx+0x29] */
            ii(0x1009_4bce, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_4bd1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_4bd3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4bd6, 4); mov(memw[ds, eax + 43], dx);            /* mov [eax+0x2b], dx */
            ii(0x1009_4bda, 2); jmp(0x1009_4c04, 0x28); goto l_0x1009_4c04; /* jmp 0x10094c04 */
        l_0x1009_4bdc:
            ii(0x1009_4bdc, 2); jmp(0x1009_4c04, 0x26); goto l_0x1009_4c04; /* jmp 0x10094c04 */
        l_0x1009_4bde:
            ii(0x1009_4bde, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1009_4be1, 3); mov(memb[ss, ebp - 24], al);            /* mov [ebp-0x18], al */
            ii(0x1009_4be4, 4); cmp(memb[ss, ebp - 24], 2);             /* cmp byte [ebp-0x18], 0x2 */
            ii(0x1009_4be8, 2); if(jb(0x1009_4bf8, 0xe)) goto l_0x1009_4bf8; /* jb 0x10094bf8 */
            ii(0x1009_4bea, 4); cmp(memb[ss, ebp - 24], 2);             /* cmp byte [ebp-0x18], 0x2 */
            ii(0x1009_4bee, 2); if(jbe(0x1009_4b80, -0x70)) goto l_0x1009_4b80; /* jbe 0x10094b80 */
            ii(0x1009_4bf0, 4); cmp(memb[ss, ebp - 24], 3);             /* cmp byte [ebp-0x18], 0x3 */
            ii(0x1009_4bf4, 2); if(jz(0x1009_4bae, -0x48)) goto l_0x1009_4bae; /* jz 0x10094bae */
            ii(0x1009_4bf6, 2); jmp(0x1009_4bdc, -0x1c); goto l_0x1009_4bdc; /* jmp 0x10094bdc */
        l_0x1009_4bf8:
            ii(0x1009_4bf8, 4); cmp(memb[ss, ebp - 24], 1);             /* cmp byte [ebp-0x18], 0x1 */
            ii(0x1009_4bfc, 6); if(jz(0x1009_4b4f, -0xb3)) goto l_0x1009_4b4f; /* jz 0x10094b4f */
            ii(0x1009_4c02, 2); jmp(0x1009_4bdc, -0x28); goto l_0x1009_4bdc; /* jmp 0x10094bdc */
        l_0x1009_4c04:
            ii(0x1009_4c04, 5); jmp(0x1009_4a9f, -0x16a); goto l_0x1009_4a9f; /* jmp 0x10094a9f */
        l_0x1009_4c09:
            ii(0x1009_4c09, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4c0c, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_4c0f, 5); call(0x1009_c6c8, 0x7ab4);              /* call 0x1009c6c8 */
            ii(0x1009_4c14, 3); lea(ebx, memd[ss, ebp - 28]);           /* lea ebx, [ebp-0x1c] */
            ii(0x1009_4c17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4c19, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_4c1b, 5); call(0x1009_c5dc, 0x79bc);              /* call 0x1009c5dc */
            ii(0x1009_4c20, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4c23, 4); mov(ax, memw[ds, eax + 43]);            /* mov ax, [eax+0x2b] */
            ii(0x1009_4c27, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_4c2a, 2); jmp(0x1009_4c34, 8); goto l_0x1009_4c34; /* jmp 0x10094c34 */
        l_0x1009_4c2c:
            ii(0x1009_4c2c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4c2f, 5); call(0x1007_6bf8, -0x1_e03c);           /* call 0x10076bf8 */
        l_0x1009_4c34:
            ii(0x1009_4c34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4c36, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4c39, 5); call(0x1013_ad71, 0xa_6133);            /* call 0x1013ad71 */
            ii(0x1009_4c3e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4c40, 6); if(jz(0x1009_4cd5, 0x8f)) goto l_0x1009_4cd5; /* jz 0x10094cd5 */
            ii(0x1009_4c46, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4c49, 5); call(0x1009_c4f8, 0x78aa);              /* call 0x1009c4f8 */
            ii(0x1009_4c4e, 5); call(0x1009_c4c4, 0x7871);              /* call 0x1009c4c4 */
            ii(0x1009_4c53, 1); cwde();                                 /* cwde */
            ii(0x1009_4c54, 5); call(0x1007_2073, -0x2_2be6);           /* call 0x10072073 */
            ii(0x1009_4c59, 3); sub(memd[ss, ebp - 8], eax);            /* sub [ebp-0x8], eax */
            ii(0x1009_4c5c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4c5f, 5); call(0x1009_c4f8, 0x7894);              /* call 0x1009c4f8 */
            ii(0x1009_4c64, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1009_4c67, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1009_4c6a, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1009_4c6d, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1009_4c70, 3); call_abs(memd[ds, edx + 112]);          /* call dword [edx+0x70] */
            ii(0x1009_4c73, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4c75, 2); if(jz(0x1009_4cd0, 0x59)) goto l_0x1009_4cd0; /* jz 0x10094cd0 */
            ii(0x1009_4c77, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1009_4c7c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4c7f, 5); call(0x1009_c4f8, 0x7874);              /* call 0x1009c4f8 */
            ii(0x1009_4c84, 5); call(0x1009_c4c4, 0x783b);              /* call 0x1009c4c4 */
            ii(0x1009_4c89, 1); cwde();                                 /* cwde */
            ii(0x1009_4c8a, 5); call(0x1007_1e00, -0x2_2e8f);           /* call 0x10071e00 */
            ii(0x1009_4c8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4c91, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4c94, 4); sub(memw[ds, eax + 45], dx);            /* sub [eax+0x2d], dx */
            ii(0x1009_4c98, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4c9b, 5); call(0x1009_c4f8, 0x7858);              /* call 0x1009c4f8 */
            ii(0x1009_4ca0, 5); call(0x1009_c4c4, 0x781f);              /* call 0x1009c4c4 */
            ii(0x1009_4ca5, 1); cwde();                                 /* cwde */
            ii(0x1009_4ca6, 5); call(0x1007_1ec5, -0x2_2de6);           /* call 0x10071ec5 */
            ii(0x1009_4cab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4cad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4cb0, 4); sub(memw[ds, eax + 47], dx);            /* sub [eax+0x2f], dx */
            ii(0x1009_4cb4, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4cb7, 5); call(0x1009_c4f8, 0x783c);              /* call 0x1009c4f8 */
            ii(0x1009_4cbc, 5); call(0x1009_c4c4, 0x7803);              /* call 0x1009c4c4 */
            ii(0x1009_4cc1, 1); cwde();                                 /* cwde */
            ii(0x1009_4cc2, 5); call(0x1007_2073, -0x2_2c54);           /* call 0x10072073 */
            ii(0x1009_4cc7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4cc9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4ccc, 4); sub(memw[ds, eax + 43], dx);            /* sub [eax+0x2b], dx */
        l_0x1009_4cd0:
            ii(0x1009_4cd0, 5); jmp(0x1009_4c2c, -0xa9); goto l_0x1009_4c2c; /* jmp 0x10094c2c */
        l_0x1009_4cd5:
            ii(0x1009_4cd5, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_4cda, 5); call(0x1007_6338, -0x1_e9a7);           /* call 0x10076338 */
            ii(0x1009_4cdf, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x1009_4ce2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4ce4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_4ce6, 5); call(0x1007_643c, -0x1_e8af);           /* call 0x1007643c */
            ii(0x1009_4ceb, 2); jmp(0x1009_4cf5, 8); goto l_0x1009_4cf5; /* jmp 0x10094cf5 */
        l_0x1009_4ced:
            ii(0x1009_4ced, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4cf0, 5); call(0x1007_6bf8, -0x1_e0fd);           /* call 0x10076bf8 */
        l_0x1009_4cf5:
            ii(0x1009_4cf5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4cf7, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4cfa, 5); call(0x1013_ad71, 0xa_6072);            /* call 0x1013ad71 */
            ii(0x1009_4cff, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4d01, 6); if(jz(0x1009_4db1, 0xaa)) goto l_0x1009_4db1; /* jz 0x10094db1 */
            ii(0x1009_4d07, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4d0a, 5); call(0x1007_63a0, -0x1_e96f);           /* call 0x100763a0 */
            ii(0x1009_4d0f, 5); cmp(memw[ds, eax + 8], 0x28);           /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_4d14, 2); if(jnz(0x1009_4d30, 0x1a)) goto l_0x1009_4d30; /* jnz 0x10094d30 */
            ii(0x1009_4d16, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4d19, 5); call(0x1007_63a0, -0x1_e97e);           /* call 0x100763a0 */
            ii(0x1009_4d1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4d20, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1009_4d23, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4d26, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1009_4d29, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4d2c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_4d2e, 2); if(jz(0x1009_4d32, 2)) goto l_0x1009_4d32; /* jz 0x10094d32 */
        l_0x1009_4d30:
            ii(0x1009_4d30, 2); jmp(0x1009_4dac, 0x7a); goto l_0x1009_4dac; /* jmp 0x10094dac */
        l_0x1009_4d32:
            ii(0x1009_4d32, 7); mov(memd[ss, ebp - 12], 0x10);          /* mov dword [ebp-0xc], 0x10 */
            ii(0x1009_4d39, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4d3c, 5); call(0x1007_63a0, -0x1_e9a1);           /* call 0x100763a0 */
            ii(0x1009_4d41, 3); mov(al, memb[ds, eax + 76]);            /* mov al, [eax+0x4c] */
            ii(0x1009_4d44, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_4d46, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_4d49, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4d4c, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1009_4d4f, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_4d52, 5); call(0x1009_490b, -0x44c);              /* call 0x1009490b */
            ii(0x1009_4d57, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4d5a, 5); call(0x1007_63a0, -0x1_e9bf);           /* call 0x100763a0 */
            ii(0x1009_4d5f, 3); mov(al, memb[ds, eax + 74]);            /* mov al, [eax+0x4a] */
            ii(0x1009_4d62, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_4d64, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_4d67, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4d6a, 3); add(edx, 0x2d);                         /* add edx, 0x2d */
            ii(0x1009_4d6d, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_4d70, 5); call(0x1009_490b, -0x46a);              /* call 0x1009490b */
            ii(0x1009_4d75, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4d78, 5); call(0x1007_63a0, -0x1_e9dd);           /* call 0x100763a0 */
            ii(0x1009_4d7d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4d7f, 3); mov(dl, memb[ds, eax + 75]);            /* mov dl, [eax+0x4b] */
            ii(0x1009_4d82, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1009_4d86, 5); call(Definitions.my_min, -0xb607);      /* call 0x10089784 */
            ii(0x1009_4d8b, 3); add(memd[ss, ebp - 8], eax);            /* add [ebp-0x8], eax */
            ii(0x1009_4d8e, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4d91, 5); call(0x1007_63a0, -0x1_e9f6);           /* call 0x100763a0 */
            ii(0x1009_4d96, 3); mov(al, memb[ds, eax + 75]);            /* mov al, [eax+0x4b] */
            ii(0x1009_4d99, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1009_4d9b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_4d9e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4da1, 3); add(edx, 0x2b);                         /* add edx, 0x2b */
            ii(0x1009_4da4, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_4da7, 5); call(0x1009_490b, -0x4a1);              /* call 0x1009490b */
        l_0x1009_4dac:
            ii(0x1009_4dac, 5); jmp(0x1009_4ced, -0xc4); goto l_0x1009_4ced; /* jmp 0x10094ced */
        l_0x1009_4db1:
            ii(0x1009_4db1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4db4, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_4db7, 5); call(0x1009_c6c8, 0x790c);              /* call 0x1009c6c8 */
            ii(0x1009_4dbc, 3); lea(ebx, memd[ss, ebp - 28]);           /* lea ebx, [ebp-0x1c] */
            ii(0x1009_4dbf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_4dc1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_4dc3, 5); call(0x1009_c560, 0x7798);              /* call 0x1009c560 */
            ii(0x1009_4dc8, 2); jmp(0x1009_4dd2, 8); goto l_0x1009_4dd2; /* jmp 0x10094dd2 */
        l_0x1009_4dca:
            ii(0x1009_4dca, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4dcd, 5); call(0x1007_6bf8, -0x1_e1da);           /* call 0x10076bf8 */
        l_0x1009_4dd2:
            ii(0x1009_4dd2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4dd4, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4dd7, 5); call(0x1013_ad71, 0xa_5f95);            /* call 0x1013ad71 */
            ii(0x1009_4ddc, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4dde, 6); if(jz(0x1009_4eac, 0xc8)) goto l_0x1009_4eac; /* jz 0x10094eac */
            ii(0x1009_4de4, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4de7, 5); call(0x1009_c4f8, 0x770c);              /* call 0x1009c4f8 */
            ii(0x1009_4dec, 5); call(0x1009_c4c4, 0x76d3);              /* call 0x1009c4c4 */
            ii(0x1009_4df1, 4); cmp(ax, 0x28);                          /* cmp ax, 0x28 */
            ii(0x1009_4df5, 6); if(jnz(0x1009_4ea7, 0xac)) goto l_0x1009_4ea7; /* jnz 0x10094ea7 */
            ii(0x1009_4dfb, 7); mov(memd[ss, ebp - 12], 0x10);          /* mov dword [ebp-0xc], 0x10 */
            ii(0x1009_4e02, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4e05, 5); call(0x1009_c4f8, 0x76ee);              /* call 0x1009c4f8 */
            ii(0x1009_4e0a, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1009_4e0d, 3); mov(ebx, memd[ss, ebp - 36]);           /* mov ebx, [ebp-0x24] */
            ii(0x1009_4e10, 3); mov(ebx, memd[ds, ebx + 2]);            /* mov ebx, [ebx+0x2] */
            ii(0x1009_4e13, 3); lea(edx, memd[ss, ebp - 52]);           /* lea edx, [ebp-0x34] */
            ii(0x1009_4e16, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1009_4e19, 3); call_abs(memd[ds, ebx + 28]);           /* call dword [ebx+0x1c] */
            ii(0x1009_4e1c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4e1f, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1009_4e22, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_4e25, 1); push(eax);                              /* push eax */
            ii(0x1009_4e26, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4e28, 1); push(eax);                              /* push eax */
            ii(0x1009_4e29, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1009_4e2c, 1); push(eax);                              /* push eax */
            ii(0x1009_4e2d, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1009_4e30, 1); push(eax);                              /* push eax */
            ii(0x1009_4e31, 3); lea(ecx, memd[ss, ebp - 64]);           /* lea ecx, [ebp-0x40] */
            ii(0x1009_4e34, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1009_4e39, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x1009_4e3d, 4); movsx(eax, memw[ss, ebp - 52]);         /* movsx eax, word [ebp-0x34] */
            ii(0x1009_4e41, 5); call(0x1014_2d0b, 0xa_dec5);            /* call 0x10142d0b */
            ii(0x1009_4e46, 4); movsx(ebx, memw[ss, ebp - 56]);         /* movsx ebx, word [ebp-0x38] */
            ii(0x1009_4e4a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4e4d, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1009_4e50, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_4e53, 5); call(0x1009_490b, -0x54d);              /* call 0x1009490b */
            ii(0x1009_4e58, 4); movsx(ebx, memw[ss, ebp - 64]);         /* movsx ebx, word [ebp-0x40] */
            ii(0x1009_4e5c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4e5f, 3); add(edx, 0x2d);                         /* add edx, 0x2d */
            ii(0x1009_4e62, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_4e65, 5); call(0x1009_490b, -0x55f);              /* call 0x1009490b */
            ii(0x1009_4e6a, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4e6d, 5); call(0x1009_c4f8, 0x7686);              /* call 0x1009c4f8 */
            ii(0x1009_4e72, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x1009_4e75, 3); mov(edx, memd[ss, ebp - 68]);           /* mov edx, [ebp-0x44] */
            ii(0x1009_4e78, 3); mov(edx, memd[ds, edx + 2]);            /* mov edx, [edx+0x2] */
            ii(0x1009_4e7b, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x1009_4e7e, 3); call_abs(memd[ds, edx + 112]);          /* call dword [edx+0x70] */
            ii(0x1009_4e81, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4e83, 2); if(jz(0x1009_4e95, 0x10)) goto l_0x1009_4e95; /* jz 0x10094e95 */
            ii(0x1009_4e85, 4); movsx(edx, memw[ss, ebp - 60]);         /* movsx edx, word [ebp-0x3c] */
            ii(0x1009_4e89, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1009_4e8d, 5); call(Definitions.my_min, -0xb70e);      /* call 0x10089784 */
            ii(0x1009_4e92, 3); add(memd[ss, ebp - 8], eax);            /* add [ebp-0x8], eax */
        l_0x1009_4e95:
            ii(0x1009_4e95, 4); movsx(ebx, memw[ss, ebp - 60]);         /* movsx ebx, word [ebp-0x3c] */
            ii(0x1009_4e99, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_4e9c, 3); add(edx, 0x2b);                         /* add edx, 0x2b */
            ii(0x1009_4e9f, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_4ea2, 5); call(0x1009_490b, -0x59c);              /* call 0x1009490b */
        l_0x1009_4ea7:
            ii(0x1009_4ea7, 5); jmp(0x1009_4dca, -0xe2); goto l_0x1009_4dca; /* jmp 0x10094dca */
        l_0x1009_4eac:
            ii(0x1009_4eac, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4eae, 5); call(0x1007_2073, -0x2_2e40);           /* call 0x10072073 */
            ii(0x1009_4eb3, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x1009_4eb7, 2); if(jg(0x1009_4ecb, 0x12)) goto l_0x1009_4ecb; /* jg 0x10094ecb */
            ii(0x1009_4eb9, 5); mov(ecx, 0x1500);                       /* mov ecx, 0x1500 */
            ii(0x1009_4ebe, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1009_4ec1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4ec3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_4ec6, 5); call(0x1009_6e02, 0x1f37);              /* call 0x10096e02 */
        l_0x1009_4ecb:
            ii(0x1009_4ecb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4ecd, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1009_4ed0, 5); call(0x1009_ba6c, 0x6b97);              /* call 0x1009ba6c */
            ii(0x1009_4ed5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_4ed7, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1009_4eda, 5); call(0x1007_5f6c, -0x1_ef73);           /* call 0x10075f6c */
            ii(0x1009_4edf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_4ee1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_4ee2, 1); pop(edi);                               /* pop edi */
            ii(0x1009_4ee3, 1); pop(esi);                               /* pop esi */
            ii(0x1009_4ee4, 1); pop(edx);                               /* pop edx */
            ii(0x1009_4ee5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_4ee6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_4ee7, 1); ret();                                  /* ret */
        }
    }
}
