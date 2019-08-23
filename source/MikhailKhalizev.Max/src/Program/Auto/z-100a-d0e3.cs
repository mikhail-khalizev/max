using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d0e3-1fe85466")]
        public void Method_100a_d0e3()
        {
            ii(0x100a_d0e3, 5); push(0x30);                             /* push 0x30 */
            ii(0x100a_d0e8, 5); call(Definitions.sys_check_available_stack_size, 0xb_8c65); /* call 0x10165d52 */
            ii(0x100a_d0ed, 1); push(ecx);                              /* push ecx */
            ii(0x100a_d0ee, 1); push(esi);                              /* push esi */
            ii(0x100a_d0ef, 1); push(edi);                              /* push edi */
            ii(0x100a_d0f0, 1); push(ebp);                              /* push ebp */
            ii(0x100a_d0f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d0f3, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_d0f9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_d0fc, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_d0ff, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100a_d102, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100a_d105, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_d108, 5); call(0x100b_8204, 0xb0f7);              /* call 0x100b8204 */
            ii(0x100a_d10d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_d110, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_6625); /* call 0x10076af0 */
            ii(0x100a_d115, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d118, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x100a_d11c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_d11f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d122, 5); cmp(memw[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_d127, 2); if(jz(0x100a_d130, 0x7)) goto l_0x100a_d130; /* jz 0x100ad130 */
            ii(0x100a_d129, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100a_d130:
            ii(0x100a_d130, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d133, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
            ii(0x100a_d137, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_d13e, 2); jmp(0x100a_d146, 0x6); goto l_0x100a_d146; /* jmp 0x100ad146 */
        l_0x100a_d140:
            ii(0x100a_d140, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_d143, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x100a_d146:
            ii(0x100a_d146, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d149, 5); call(0x100b_82bc, 0xb16e);              /* call 0x100b82bc */
            ii(0x100a_d14e, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100a_d152, 6); if(jle(0x100a_d1dd, 0x85)) goto l_0x100a_d1dd; /* jle 0x100ad1dd */
            ii(0x100a_d158, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_d15c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d15f, 5); call(0x100b_827c, 0xb118);              /* call 0x100b827c */
            ii(0x100a_d164, 4); movsx(dx, memb[ds, eax]);               /* movsx dx, byte [eax] */
            ii(0x100a_d168, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d16b, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100a_d16e, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_d172, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d175, 5); call(0x100b_827c, 0xb102);              /* call 0x100b827c */
            ii(0x100a_d17a, 5); movsx(dx, memb[ds, eax + 0x1]);         /* movsx dx, byte [eax+0x1] */
            ii(0x100a_d17f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d182, 4); add(memw[ds, eax + 0x2], dx);           /* add [eax+0x2], dx */
            ii(0x100a_d186, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d189, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d18c, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_d18f, 5); call(0x100a_aa64, -0x2730);             /* call 0x100aaa64 */
            ii(0x100a_d194, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d197, 4); mov(ax, memw[ds, eax + 0x1e]);          /* mov ax, [eax+0x1e] */
            ii(0x100a_d19b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d19e, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100a_d1a1, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x100a_d1a5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d1a8, 4); mov(ax, memw[ds, eax + 0x20]);          /* mov ax, [eax+0x20] */
            ii(0x100a_d1ac, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d1af, 4); sub(ax, memw[ds, edx + 0x2]);           /* sub ax, [edx+0x2] */
            ii(0x100a_d1b3, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x100a_d1b7, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x100a_d1bb, 4); movsx(eax, memw[ss, ebp - 0x16]);       /* movsx eax, word [ebp-0x16] */
            ii(0x100a_d1bf, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_d1c2, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100a_d1c4, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100a_d1c8, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100a_d1cc, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_d1cf, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100a_d1d1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100a_d1d5, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100a_d1d7, 6); if(jg(0x100a_d140, -0x9d)) goto l_0x100a_d140; /* jg 0x100ad140 */
        l_0x100a_d1dd:
            ii(0x100a_d1dd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d1e0, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_d1e3, 5); call(Definitions.my_3_get_count, -0x2_1d68); /* call 0x1008b480 */
            ii(0x100a_d1e8, 1); cwde();                                 /* cwde */
            ii(0x100a_d1e9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d1eb, 2); if(jle(0x100a_d204, 0x17)) goto l_0x100a_d204; /* jle 0x100ad204 */
            ii(0x100a_d1ed, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_d1f2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d1f5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d1f8, 5); call(0x1007_65d0, -0x3_6c2d);           /* call 0x100765d0 */
            ii(0x100a_d1fd, 5); call(0x100a_297d, -0xa885);             /* call 0x100a297d */
            ii(0x100a_d202, 2); jmp(0x100a_d236, 0x32); goto l_0x100a_d236; /* jmp 0x100ad236 */
        l_0x100a_d204:
            ii(0x100a_d204, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d207, 5); cmp(memw[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_d20c, 2); if(jz(0x100a_d229, 0x1b)) goto l_0x100a_d229; /* jz 0x100ad229 */
            ii(0x100a_d20e, 5); call(0x1008_b0e4, -0x2_212f);           /* call 0x1008b0e4 */
            ii(0x100a_d213, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d215, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_d217, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d21a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d21d, 5); call(0x1007_65d0, -0x3_6c52);           /* call 0x100765d0 */
            ii(0x100a_d222, 5); call(0x100a_297d, -0xa8aa);             /* call 0x100a297d */
            ii(0x100a_d227, 2); jmp(0x100a_d236, 0xd); goto l_0x100a_d236; /* jmp 0x100ad236 */
        l_0x100a_d229:
            ii(0x100a_d229, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_d22e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_d231, 5); call(0x100a_d02d, -0x209);              /* call 0x100ad02d */
        l_0x100a_d236:
            ii(0x100a_d236, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d238, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d23b, 5); call(0x100b_7294, 0xa054);              /* call 0x100b7294 */
            ii(0x100a_d240, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d242, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_d243, 1); pop(edi);                               /* pop edi */
            ii(0x100a_d244, 1); pop(esi);                               /* pop esi */
            ii(0x100a_d245, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_d246, 1); ret();                                  /* ret */
        }
    }
}
