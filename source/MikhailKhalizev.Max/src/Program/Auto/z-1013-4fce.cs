using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4fce-769d3902")]
        public void Method_1013_4fce()
        {
            ii(0x1013_4fce, 5); push(0x54);                             /* push 0x54 */
            ii(0x1013_4fd3, 5); call(Definitions.sys_check_available_stack_size, 0x3_0d7a); /* call 0x10165d52 */
            ii(0x1013_4fd8, 1); push(ebx);                              /* push ebx */
            ii(0x1013_4fd9, 1); push(ecx);                              /* push ecx */
            ii(0x1013_4fda, 1); push(esi);                              /* push esi */
            ii(0x1013_4fdb, 1); push(edi);                              /* push edi */
            ii(0x1013_4fdc, 1); push(ebp);                              /* push ebp */
            ii(0x1013_4fdd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4fdf, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1013_4fe5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_4fe8, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_4feb, 7); mov(memd[ss, ebp - 0x3c], 0x40);        /* mov dword [ebp-0x3c], 0x40 */
            ii(0x1013_4ff2, 6); mov(edx, memd[ds, 0x101c_946c]);        /* mov edx, [0x101c946c] */
            ii(0x1013_4ff8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_4ffb, 3); add(edx, 0x7);                          /* add edx, 0x7 */
            ii(0x1013_4ffe, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5000, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5003, 3); shl(edx, 0x3);                          /* shl edx, 0x3 */
            ii(0x1013_5006, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1013_5008, 3); sar(eax, 0x3);                          /* sar eax, 0x3 */
            ii(0x1013_500b, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_500e, 7); cmp(memb[ds, 0x101c_814a], 0);          /* cmp byte [0x101c814a], 0x0 */
            ii(0x1013_5015, 2); if(jz(0x1013_5036, 0x1f)) goto l_0x1013_5036; /* jz 0x10135036 */
            ii(0x1013_5017, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1013_501a, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1013_501d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5020, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_5022, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_5024, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1013_5027, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_502b, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x1013_502e, 5); call(Definitions.sys_new_arr, 0x3_0fdd); /* call 0x10166010 */
            ii(0x1013_5033, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x1013_5036:
            ii(0x1013_5036, 5); mov(eax, memd[ds, 0x101c_946c]);        /* mov eax, [0x101c946c] */
            ii(0x1013_503b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_503e, 4); imul(eax, memd[ss, ebp - 0x3c]);        /* imul eax, [ebp-0x3c] */
            ii(0x1013_5042, 4); imul(eax, memd[ss, ebp - 0x3c]);        /* imul eax, [ebp-0x3c] */
            ii(0x1013_5046, 5); call(Definitions.sys_new_arr, 0x3_0fc5); /* call 0x10166010 */
            ii(0x1013_504b, 5); mov(memd[ds, 0x101c_944c], eax);        /* mov [0x101c944c], eax */
            ii(0x1013_5050, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1013_5057, 5); mov(eax, memd[ds, 0x101c_944c]);        /* mov eax, [0x101c944c] */
            ii(0x1013_505c, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1013_505f, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1013_5066, 2); jmp(0x1013_506e, 0x6); goto l_0x1013_506e; /* jmp 0x1013506e */
        l_0x1013_5068:
            ii(0x1013_5068, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_506b, 3); add(memd[ss, ebp - 0x20], eax);         /* add [ebp-0x20], eax */
        l_0x1013_506e:
            ii(0x1013_506e, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_5071, 7); cmp(ax, memw[ds, 0x101c_946e]);         /* cmp ax, [0x101c946e] */
            ii(0x1013_5078, 6); if(jge(0x1013_5194, 0x116)) goto l_0x1013_5194; /* jge 0x10135194 */
            ii(0x1013_507e, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_5082, 3); imul(edx, edx, 0x32);                   /* imul edx, edx, 0x32 */
            ii(0x1013_5085, 6); mov(ebx, memd[ds, 0x101c_946c]);        /* mov ebx, [0x101c946c] */
            ii(0x1013_508b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_508e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_5090, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_5093, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_5095, 3); lea(edx, eax + 0x14);                   /* lea edx, [eax+0x14] */
            ii(0x1013_5098, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_509b, 5); call(0x1013_69e9, 0x1949);              /* call 0x101369e9 */
            ii(0x1013_50a0, 7); cmp(memb[ds, 0x101c_814a], 0);          /* cmp byte [0x101c814a], 0x0 */
            ii(0x1013_50a7, 2); if(jnz(0x1013_50bb, 0x12)) goto l_0x1013_50bb; /* jnz 0x101350bb */
            ii(0x1013_50a9, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_50ad, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x1013_50b0, 6); mov(edx, memd[ds, 0x101c_944c]);        /* mov edx, [0x101c944c] */
            ii(0x1013_50b6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_50b8, 3); mov(memd[ss, ebp - 0x30], edx);         /* mov [ebp-0x30], edx */
        l_0x1013_50bb:
            ii(0x1013_50bb, 5); mov(eax, memd[ds, 0x101c_946c]);        /* mov eax, [0x101c946c] */
            ii(0x1013_50c0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_50c3, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_50c7, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_50c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_50cb, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_50cf, 5); call(Definitions.my_min, -0xa_b950);    /* call 0x10089784 */
            ii(0x1013_50d4, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_50d7, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_50db, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x1013_50de, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_50e1, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1013_50e4, 3); mov(ebx, memd[ss, ebp - 0x28]);         /* mov ebx, [ebp-0x28] */
            ii(0x1013_50e7, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_50ec, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_50ef, 5); call(Definitions.my_fread, -0x4_5c65);  /* call 0x100ef48f */
            ii(0x1013_50f4, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x1013_50f7, 2); if(jz(0x1013_5102, 0x9)) goto l_0x1013_5102; /* jz 0x10135102 */
            ii(0x1013_50f9, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1013_50fd, 5); jmp(0x1013_51b6, 0xb4); goto l_0x1013_51b6; /* jmp 0x101351b6 */
        l_0x1013_5102:
            ii(0x1013_5102, 7); cmp(memb[ds, 0x101c_814a], 0);          /* cmp byte [0x101c814a], 0x0 */
            ii(0x1013_5109, 6); if(jz(0x1013_518f, 0x80)) goto l_0x1013_518f; /* jz 0x1013518f */
            ii(0x1013_510f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_5112, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1013_5115, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_5119, 4); imul(eax, memd[ss, ebp - 0x3c]);        /* imul eax, [ebp-0x3c] */
            ii(0x1013_511d, 4); imul(eax, memd[ss, ebp - 0x3c]);        /* imul eax, [ebp-0x3c] */
            ii(0x1013_5121, 6); mov(edx, memd[ds, 0x101c_944c]);        /* mov edx, [0x101c944c] */
            ii(0x1013_5127, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_5129, 3); mov(memd[ss, ebp - 0x34], edx);         /* mov [ebp-0x34], edx */
            ii(0x1013_512c, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_5133, 2); jmp(0x1013_513b, 0x6); goto l_0x1013_513b; /* jmp 0x1013513b */
        l_0x1013_5135:
            ii(0x1013_5135, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_5138, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1013_513b:
            ii(0x1013_513b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_513e, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x1013_5142, 2); if(jge(0x1013_518f, 0x4b)) goto l_0x1013_518f; /* jge 0x1013518f */
            ii(0x1013_5144, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1013_514b, 2); jmp(0x1013_5153, 0x6); goto l_0x1013_5153; /* jmp 0x10135153 */
        l_0x1013_514d:
            ii(0x1013_514d, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_5150, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1013_5153:
            ii(0x1013_5153, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_5157, 3); cmp(eax, memd[ss, ebp - 0x3c]);         /* cmp eax, [ebp-0x3c] */
            ii(0x1013_515a, 2); if(jge(0x1013_518d, 0x31)) goto l_0x1013_518d; /* jge 0x1013518d */
            ii(0x1013_515c, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_5163, 2); jmp(0x1013_516b, 0x6); goto l_0x1013_516b; /* jmp 0x1013516b */
        l_0x1013_5165:
            ii(0x1013_5165, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_5168, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1013_516b:
            ii(0x1013_516b, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_516f, 3); cmp(eax, memd[ss, ebp - 0x3c]);         /* cmp eax, [ebp-0x3c] */
            ii(0x1013_5172, 2); if(jge(0x1013_5187, 0x13)) goto l_0x1013_5187; /* jge 0x10135187 */
            ii(0x1013_5174, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1013_5177, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
            ii(0x1013_517a, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1013_517d, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_517f, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1013_5181, 4); add(memd[ss, ebp - 0x38], 0x2);         /* add dword [ebp-0x38], 0x2 */
            ii(0x1013_5185, 2); jmp(0x1013_5165, -0x22); goto l_0x1013_5165; /* jmp 0x10135165 */
        l_0x1013_5187:
            ii(0x1013_5187, 4); add(memd[ss, ebp - 0x38], 0x40);        /* add dword [ebp-0x38], 0x40 */
            ii(0x1013_518b, 2); jmp(0x1013_514d, -0x40); goto l_0x1013_514d; /* jmp 0x1013514d */
        l_0x1013_518d:
            ii(0x1013_518d, 2); jmp(0x1013_5135, -0x5a); goto l_0x1013_5135; /* jmp 0x10135135 */
        l_0x1013_518f:
            ii(0x1013_518f, 5); jmp(0x1013_5068, -0x12c); goto l_0x1013_5068; /* jmp 0x10135068 */
        l_0x1013_5194:
            ii(0x1013_5194, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x1013_5199, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_519c, 5); call(0x1013_69e9, 0x1848);              /* call 0x101369e9 */
            ii(0x1013_51a1, 7); cmp(memb[ds, 0x101c_814a], 0);          /* cmp byte [0x101c814a], 0x0 */
            ii(0x1013_51a8, 2); if(jz(0x1013_51b2, 0x8)) goto l_0x1013_51b2; /* jz 0x101351b2 */
            ii(0x1013_51aa, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_51ad, 5); call(Definitions.sys_delete, 0x3_0db2); /* call 0x10165f64 */
        l_0x1013_51b2:
            ii(0x1013_51b2, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1013_51b6:
            ii(0x1013_51b6, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1013_51b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_51bb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_51bc, 1); pop(edi);                               /* pop edi */
            ii(0x1013_51bd, 1); pop(esi);                               /* pop esi */
            ii(0x1013_51be, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_51bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_51c0, 1); ret();                                  /* ret */
        }
    }
}
