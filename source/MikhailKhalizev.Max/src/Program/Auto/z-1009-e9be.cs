using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e9be-76b95200")]
        public void Method_1009_e9be()
        {
            ii(0x1009_e9be, 5); push(0x38);                             /* push 0x38 */
            ii(0x1009_e9c3, 5); call(Definitions.sys_check_available_stack_size, 0xc_738a); /* call 0x10165d52 */
            ii(0x1009_e9c8, 1); push(ecx);                              /* push ecx */
            ii(0x1009_e9c9, 1); push(esi);                              /* push esi */
            ii(0x1009_e9ca, 1); push(edi);                              /* push edi */
            ii(0x1009_e9cb, 1); push(ebp);                              /* push ebp */
            ii(0x1009_e9cc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e9ce, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_e9d4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_e9d7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_e9da, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1009_e9dd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_e9e0, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_e9e3, 5); call(0x1007_5e64, -0x2_8b84);           /* call 0x10075e64 */
            ii(0x1009_e9e8, 1); push(eax);                              /* push eax */
            ii(0x1009_e9e9, 5); mov(ecx, 0x1b00);                       /* mov ecx, 0x1b00 */
            ii(0x1009_e9ee, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_e9f0, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1009_e9f4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_e9f7, 5); call(0x1009_cc08, -0x1df4);             /* call 0x1009cc08 */
            ii(0x1009_e9fc, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_e9ff, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_ea02, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1009_ea05, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ea08, 7); mov(memd[ds, eax + 2], 0x101b_49c4);    /* mov dword [eax+0x2], 0x101b49c4 */
            ii(0x1009_ea0f, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x1009_ea14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_ea16, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ea19, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_ea1c, 5); call(Definitions.sys_memset, 0xc_73bf); /* call 0x10165de0 */
            ii(0x1009_ea21, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ea24, 4); mov(memb[ds, eax + 85], 1);             /* mov byte [eax+0x55], 0x1 */
            ii(0x1009_ea28, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1009_ea2d, 5); call(0x100c_dec2, 0x2_f490);            /* call 0x100cdec2 */
            ii(0x1009_ea32, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_ea34, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ea37, 3); mov(memb[ds, eax + 114], dl);           /* mov [eax+0x72], dl */
            ii(0x1009_ea3a, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1009_ea3f, 5); call(0x100c_dec2, 0x2_f47e);            /* call 0x100cdec2 */
            ii(0x1009_ea44, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_ea46, 2); if(jz(0x1009_ea57, 0xf)) goto l_0x1009_ea57; /* jz 0x1009ea57 */
            ii(0x1009_ea48, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1009_ea4d, 5); call(0x1007_5fdc, -0x2_8a76);           /* call 0x10075fdc */
            ii(0x1009_ea52, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1009_ea55, 2); if(jge(0x1009_ea59, 2)) goto l_0x1009_ea59; /* jge 0x1009ea59 */
        l_0x1009_ea57:
            ii(0x1009_ea57, 2); jmp(0x1009_ea5f, 6); goto l_0x1009_ea5f; /* jmp 0x1009ea5f */
        l_0x1009_ea59:
            ii(0x1009_ea59, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_ea5d, 2); jmp(0x1009_ea63, 4); goto l_0x1009_ea63; /* jmp 0x1009ea63 */
        l_0x1009_ea5f:
            ii(0x1009_ea5f, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
        l_0x1009_ea63:
            ii(0x1009_ea63, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1009_ea66, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1009_ea69, 3); mov(memb[ds, edx + 106], al);           /* mov [edx+0x6a], al */
            ii(0x1009_ea6c, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1009_ea71, 5); call(0x100c_dec2, 0x2_f44c);            /* call 0x100cdec2 */
            ii(0x1009_ea76, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_ea78, 2); if(jz(0x1009_ea89, 0xf)) goto l_0x1009_ea89; /* jz 0x1009ea89 */
            ii(0x1009_ea7a, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1009_ea7f, 5); call(0x1007_5fdc, -0x2_8aa8);           /* call 0x10075fdc */
            ii(0x1009_ea84, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1009_ea87, 2); if(jge(0x1009_ea8b, 2)) goto l_0x1009_ea8b; /* jge 0x1009ea8b */
        l_0x1009_ea89:
            ii(0x1009_ea89, 2); jmp(0x1009_ea91, 6); goto l_0x1009_ea91; /* jmp 0x1009ea91 */
        l_0x1009_ea8b:
            ii(0x1009_ea8b, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_ea8f, 2); jmp(0x1009_ea95, 4); goto l_0x1009_ea95; /* jmp 0x1009ea95 */
        l_0x1009_ea91:
            ii(0x1009_ea91, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
        l_0x1009_ea95:
            ii(0x1009_ea95, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x1009_ea98, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1009_ea9b, 3); mov(memb[ds, edx + 101], al);           /* mov [edx+0x65], al */
            ii(0x1009_ea9e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_eaa1, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1009_eaa4, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1009_eaa7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_eaa9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_eaaa, 1); pop(edi);                               /* pop edi */
            ii(0x1009_eaab, 1); pop(esi);                               /* pop esi */
            ii(0x1009_eaac, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_eaad, 1); ret();                                  /* ret */
        }
    }
}
