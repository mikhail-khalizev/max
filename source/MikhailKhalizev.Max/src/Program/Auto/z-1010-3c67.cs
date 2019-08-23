using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3c67-b474d584")]
        public void Method_1010_3c67()
        {
            ii(0x1010_3c67, 5); push(0x30);                             /* push 0x30 */
            ii(0x1010_3c6c, 5); call(Definitions.sys_check_available_stack_size, 0x6_20e1); /* call 0x10165d52 */
            ii(0x1010_3c71, 1); push(ebx);                              /* push ebx */
            ii(0x1010_3c72, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3c73, 1); push(esi);                              /* push esi */
            ii(0x1010_3c74, 1); push(edi);                              /* push edi */
            ii(0x1010_3c75, 1); push(ebp);                              /* push ebp */
            ii(0x1010_3c76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3c78, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_3c7e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_3c81, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_3c84, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_3c88, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3c8b, 5); call(0x1010_45d4, 0x944);               /* call 0x101045d4 */
            ii(0x1010_3c90, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_3c93, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1010_3c97, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3c9a, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1010_3c9d, 5); mov(edx, StringDefinitions.HashSize2);  /* mov edx, 0x101a3208 */
            ii(0x1010_3ca2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3ca5, 5); call(0x1014_74f5, 0x4_384b);            /* call 0x101474f5 */
            ii(0x1010_3caa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3cad, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1010_3caf, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_3cb2, 5); mov(edx, StringDefinitions.XShift2);    /* mov edx, 0x101a3212 */
            ii(0x1010_3cb7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3cba, 5); call(0x1014_74f5, 0x4_3836);            /* call 0x101474f5 */
            ii(0x1010_3cbf, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_3cc6, 2); jmp(0x1010_3cce, 0x6); goto l_0x1010_3cce; /* jmp 0x10103cce */
        l_0x1010_3cc8:
            ii(0x1010_3cc8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_3ccb, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1010_3cce:
            ii(0x1010_3cce, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_3cd1, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_3cd4, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1010_3cd7, 6); if(jge(0x1010_3d82, 0xa5)) goto l_0x1010_3d82; /* jge 0x10103d82 */
            ii(0x1010_3cdd, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_3ce1, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_3ce4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3ce7, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1010_3cea, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_3cec, 5); call(0x1007_6b90, -0x8_d161);           /* call 0x10076b90 */
            ii(0x1010_3cf1, 1); cwde();                                 /* cwde */
            ii(0x1010_3cf2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_3cf4, 6); if(jz(0x1010_3d7d, 0x83)) goto l_0x1010_3d7d; /* jz 0x10103d7d */
            ii(0x1010_3cfa, 5); mov(edx, StringDefinitions.Entry2);     /* mov edx, 0x101a321a */
            ii(0x1010_3cff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3d02, 5); call(0x1014_73de, 0x4_36d7);            /* call 0x101473de */
            ii(0x1010_3d07, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_3d0b, 5); mov(edx, StringDefinitions.Index6);     /* mov edx, 0x101a3220 */
            ii(0x1010_3d10, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3d13, 5); call(0x1014_74f5, 0x4_37dd);            /* call 0x101474f5 */
            ii(0x1010_3d18, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_3d1c, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_3d1f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3d22, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1010_3d25, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_3d27, 5); call(0x1010_46a4, 0x978);               /* call 0x101046a4 */
            ii(0x1010_3d2c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3d2e, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3d31, 5); call(0x1010_4514, 0x7de);               /* call 0x10104514 */
            ii(0x1010_3d36, 2); jmp(0x1010_3d40, 0x8); goto l_0x1010_3d40; /* jmp 0x10103d40 */
        l_0x1010_3d38:
            ii(0x1010_3d38, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3d3b, 5); call(0x1007_6bf8, -0x8_d148);           /* call 0x10076bf8 */
        l_0x1010_3d40:
            ii(0x1010_3d40, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3d42, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3d45, 5); call(0x1013_ad71, 0x3_7027);            /* call 0x1013ad71 */
            ii(0x1010_3d4a, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3d4c, 2); if(jz(0x1010_3d75, 0x27)) goto l_0x1010_3d75; /* jz 0x10103d75 */
            ii(0x1010_3d4e, 5); mov(edx, StringDefinitions.List2);      /* mov edx, 0x101a3226 */
            ii(0x1010_3d53, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3d56, 5); call(0x1014_73de, 0x4_3683);            /* call 0x101473de */
            ii(0x1010_3d5b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_3d5e, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3d61, 5); call(0x1010_44b0, 0x74a);               /* call 0x101044b0 */
            ii(0x1010_3d66, 5); call(0x1010_31e1, -0xb8a);              /* call 0x101031e1 */
            ii(0x1010_3d6b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3d6e, 5); call(0x1014_7446, 0x4_36d3);            /* call 0x10147446 */
            ii(0x1010_3d73, 2); jmp(0x1010_3d38, -0x3d); goto l_0x1010_3d38; /* jmp 0x10103d38 */
        l_0x1010_3d75:
            ii(0x1010_3d75, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3d78, 5); call(0x1014_7446, 0x4_36c9);            /* call 0x10147446 */
        l_0x1010_3d7d:
            ii(0x1010_3d7d, 5); jmp(0x1010_3cc8, -0xba); goto l_0x1010_3cc8; /* jmp 0x10103cc8 */
        l_0x1010_3d82:
            ii(0x1010_3d82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3d84, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3d87, 5); call(0x1010_4470, 0x6e4);               /* call 0x10104470 */
            ii(0x1010_3d8c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3d8e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_3d8f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_3d90, 1); pop(esi);                               /* pop esi */
            ii(0x1010_3d91, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3d92, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_3d93, 1); ret();                                  /* ret */
        }
    }
}
