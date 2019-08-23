using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_4fea-b21ab9f3")]
        public void Method_1009_4fea()
        {
            ii(0x1009_4fea, 5); push(0x44);                             /* push 0x44 */
            ii(0x1009_4fef, 5); call(Definitions.sys_check_available_stack_size, 0xd_0d5e); /* call 0x10165d52 */
            ii(0x1009_4ff4, 1); push(esi);                              /* push esi */
            ii(0x1009_4ff5, 1); push(edi);                              /* push edi */
            ii(0x1009_4ff6, 1); push(ebp);                              /* push ebp */
            ii(0x1009_4ff7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_4ff9, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1009_4fff, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_5002, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1009_5005, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_5008, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_500b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_500e, 5); call(Definitions.my_ctor_0x101b_4184, -0x1_e523); /* call 0x10076af0 */
            ii(0x1009_5013, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1009_5017, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_501a, 2); if(jge(0x1009_5023, 0x7)) goto l_0x1009_5023; /* jge 0x10095023 */
            ii(0x1009_501c, 7); mov(memd[ss, ebp - 0xc], 0x1);          /* mov dword [ebp-0xc], 0x1 */
        l_0x1009_5023:
            ii(0x1009_5023, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1009_5028, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_502b, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1009_502f, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5030, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_5032, 2); if(jl(0x1009_503e, 0xa)) goto l_0x1009_503e; /* jl 0x1009503e */
            ii(0x1009_5034, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x1009_503a, 1); dec(eax);                               /* dec eax */
            ii(0x1009_503b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1009_503e:
            ii(0x1009_503e, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1009_5042, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_5045, 2); if(jge(0x1009_504e, 0x7)) goto l_0x1009_504e; /* jge 0x1009504e */
            ii(0x1009_5047, 7); mov(memd[ss, ebp - 0x8], 0x1);          /* mov dword [ebp-0x8], 0x1 */
        l_0x1009_504e:
            ii(0x1009_504e, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1009_5053, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5056, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1009_505a, 1); dec(eax);                               /* dec eax */
            ii(0x1009_505b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_505d, 2); if(jl(0x1009_5069, 0xa)) goto l_0x1009_5069; /* jl 0x10095069 */
            ii(0x1009_505f, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x1009_5065, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5066, 3); mov(memd[ss, ebp + 0x10], eax);         /* mov [ebp+0x10], eax */
        l_0x1009_5069:
            ii(0x1009_5069, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_506c, 4); mov(memw[ss, ebp - 0x14], ax);          /* mov [ebp-0x14], ax */
            ii(0x1009_5070, 2); jmp(0x1009_5079, 0x7); goto l_0x1009_5079; /* jmp 0x10095079 */
        l_0x1009_5072:
            ii(0x1009_5072, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_5075, 4); inc(memw[ss, ebp - 0x14]);              /* inc word [ebp-0x14] */
        l_0x1009_5079:
            ii(0x1009_5079, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_507c, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1009_5080, 6); if(jge(0x1009_513c, 0xb6)) goto l_0x1009_513c; /* jge 0x1009513c */
            ii(0x1009_5086, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_5089, 4); mov(memw[ss, ebp - 0x12], ax);          /* mov [ebp-0x12], ax */
            ii(0x1009_508d, 2); jmp(0x1009_5096, 0x7); goto l_0x1009_5096; /* jmp 0x10095096 */
        l_0x1009_508f:
            ii(0x1009_508f, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x1009_5092, 4); inc(memw[ss, ebp - 0x12]);              /* inc word [ebp-0x12] */
        l_0x1009_5096:
            ii(0x1009_5096, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x1009_5099, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1009_509d, 6); if(jge(0x1009_5137, 0x94)) goto l_0x1009_5137; /* jge 0x10095137 */
            ii(0x1009_50a3, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1009_50a8, 5); call(Definitions.sys_new, 0xd_0d53);    /* call 0x10165e00 */
            ii(0x1009_50ad, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_50b0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_50b3, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_50b6, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1009_50ba, 2); if(jz(0x1009_50ec, 0x30)) goto l_0x1009_50ec; /* jz 0x100950ec */
            ii(0x1009_50bc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_50bf, 1); push(eax);                              /* push eax */
            ii(0x1009_50c0, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1009_50c3, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_50c6, 5); call(0x1007_5e64, -0x1_f267);           /* call 0x10075e64 */
            ii(0x1009_50cb, 1); push(eax);                              /* push eax */
            ii(0x1009_50cc, 5); mov(ecx, 0xc);                          /* mov ecx, 0xc */
            ii(0x1009_50d1, 5); mov(ebx, 0x800);                        /* mov ebx, 0x800 */
            ii(0x1009_50d6, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1009_50d9, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_50dc, 5); call(0x1008_c999, -0x8748);             /* call 0x1008c999 */
            ii(0x1009_50e1, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_50e4, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_50e7, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1009_50ea, 2); jmp(0x1009_50f2, 0x6); goto l_0x1009_50f2; /* jmp 0x100950f2 */
        l_0x1009_50ec:
            ii(0x1009_50ec, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_50ef, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1009_50f2:
            ii(0x1009_50f2, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x1009_50f5, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_50f8, 5); call(0x1009_c7e0, 0x76e3);              /* call 0x1009c7e0 */
            ii(0x1009_50fd, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_5100, 5); call(0x1009_c76c, 0x7667);              /* call 0x1009c76c */
            ii(0x1009_5105, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5107, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_510a, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_510d, 5); call(0x1009_c698, 0x7586);              /* call 0x1009c698 */
            ii(0x1009_5112, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_5115, 5); call(0x1009_c76c, 0x7652);              /* call 0x1009c76c */
            ii(0x1009_511a, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x1009_511f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5121, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_5123, 5); call(0x100a_4d50, 0xfc28);              /* call 0x100a4d50 */
            ii(0x1009_5128, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_512a, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_512d, 5); call(0x1009_b9ec, 0x68ba);              /* call 0x1009b9ec */
            ii(0x1009_5132, 5); jmp(0x1009_508f, -0xa8); goto l_0x1009_508f; /* jmp 0x1009508f */
        l_0x1009_5137:
            ii(0x1009_5137, 5); jmp(0x1009_5072, -0xca); goto l_0x1009_5072; /* jmp 0x10095072 */
        l_0x1009_513c:
            ii(0x1009_513c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_513e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_513f, 1); pop(edi);                               /* pop edi */
            ii(0x1009_5140, 1); pop(esi);                               /* pop esi */
            ii(0x1009_5141, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
