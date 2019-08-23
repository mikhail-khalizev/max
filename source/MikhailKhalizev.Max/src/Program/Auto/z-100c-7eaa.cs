using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7eaa-6287f054")]
        public void Method_100c_7eaa()
        {
            ii(0x100c_7eaa, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100c_7eaf, 5); call(Definitions.sys_check_available_stack_size, 0x9_de9e); /* call 0x10165d52 */
            ii(0x100c_7eb4, 1); push(esi);                              /* push esi */
            ii(0x100c_7eb5, 1); push(edi);                              /* push edi */
            ii(0x100c_7eb6, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7eb7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7eb9, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_7ebf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_7ec2, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100c_7ec5, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_7ec8, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_7ecb, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_7ed2, 2); jmp(0x100c_7eda, 0x6); goto l_0x100c_7eda; /* jmp 0x100c7eda */
        l_0x100c_7ed4:
            ii(0x100c_7ed4, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_7ed7, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x100c_7eda:
            ii(0x100c_7eda, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_7ede, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_7ee1, 6); if(jge(0x100c_7f6b, 0x84)) goto l_0x100c_7f6b; /* jge 0x100c7f6b */
            ii(0x100c_7ee7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_7eea, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100c_7eee, 2); if(jz(0x100c_7f08, 0x18)) goto l_0x100c_7f08; /* jz 0x100c7f08 */
            ii(0x100c_7ef0, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_7ef4, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_7ef7, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100c_7efc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_7efe, 5); call(Definitions.my_2_get_count, -0x3_cb9b); /* call 0x1008b368 */
            ii(0x100c_7f03, 1); cwde();                                 /* cwde */
            ii(0x100c_7f04, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_7f06, 2); if(jg(0x100c_7f0a, 0x2)) goto l_0x100c_7f0a; /* jg 0x100c7f0a */
        l_0x100c_7f08:
            ii(0x100c_7f08, 2); jmp(0x100c_7f66, 0x5c); goto l_0x100c_7f66; /* jmp 0x100c7f66 */
        l_0x100c_7f0a:
            ii(0x100c_7f0a, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_7f0d, 5); call(Definitions.my_ctor_0x101b_4184, -0x5_1422); /* call 0x10076af0 */
            ii(0x100c_7f12, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_7f16, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_7f19, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7f1c, 7); sub(ax, memw[ds, edx + 0x101c_35bc]);   /* sub ax, [edx+0x101c35bc] */
            ii(0x100c_7f23, 4); mov(memw[ss, ebp - 0x1c], ax);          /* mov [ebp-0x1c], ax */
            ii(0x100c_7f27, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_7f2b, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100c_7f2e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7f31, 7); sub(ax, memw[ds, edx + 0x101c_35be]);   /* sub ax, [edx+0x101c35be] */
            ii(0x100c_7f38, 4); mov(memw[ss, ebp - 0x1a], ax);          /* mov [ebp-0x1a], ax */
            ii(0x100c_7f3c, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_7f40, 5); call(/* sys */ 0x1016_5df8, 0x9_deb3);  /* call 0x10165df8 */
            ii(0x100c_7f45, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_7f49, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100c_7f4b, 2); if(jg(0x100c_7f5e, 0x11)) goto l_0x100c_7f5e; /* jg 0x100c7f5e */
            ii(0x100c_7f4d, 4); movsx(eax, memw[ss, ebp - 0x1a]);       /* movsx eax, word [ebp-0x1a] */
            ii(0x100c_7f51, 5); call(/* sys */ 0x1016_5df8, 0x9_dea2);  /* call 0x10165df8 */
            ii(0x100c_7f56, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_7f5a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100c_7f5c, 2); if(jle(0x100c_7f60, 0x2)) goto l_0x100c_7f60; /* jle 0x100c7f60 */
        l_0x100c_7f5e:
            ii(0x100c_7f5e, 2); jmp(0x100c_7f66, 0x6); goto l_0x100c_7f66; /* jmp 0x100c7f66 */
        l_0x100c_7f60:
            ii(0x100c_7f60, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x100c_7f64, 2); jmp(0x100c_7f6f, 0x9); goto l_0x100c_7f6f; /* jmp 0x100c7f6f */
        l_0x100c_7f66:
            ii(0x100c_7f66, 5); jmp(0x100c_7ed4, -0x97); goto l_0x100c_7ed4; /* jmp 0x100c7ed4 */
        l_0x100c_7f6b:
            ii(0x100c_7f6b, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x100c_7f6f:
            ii(0x100c_7f6f, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x100c_7f72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7f74, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7f75, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7f76, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7f77, 1); ret();                                  /* ret */
        }
    }
}
