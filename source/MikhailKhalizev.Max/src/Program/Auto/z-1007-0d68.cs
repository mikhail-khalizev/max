using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_0d68-6f0cc73")]
        public void Method_1007_0d68()
        {
            ii(0x1007_0d68, 5); push(0x48);                             /* push 0x48 */
            ii(0x1007_0d6d, 5); call(Definitions.sys_check_available_stack_size, 0xf_4fe0); /* call 0x10165d52 */
            ii(0x1007_0d72, 1); push(esi);                              /* push esi */
            ii(0x1007_0d73, 1); push(edi);                              /* push edi */
            ii(0x1007_0d74, 1); push(ebp);                              /* push ebp */
            ii(0x1007_0d75, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_0d77, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1007_0d7d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_0d80, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1007_0d83, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_0d86, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1007_0d89, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0d8d, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1007_0d90, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_0d93, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0d96, 4); imul(eax, memd[ss, ebp - 0x14]);        /* imul eax, [ebp-0x14] */
            ii(0x1007_0d9a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_0d9d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0da0, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1007_0da3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_0da6, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1007_0daa, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1007_0dac, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x1007_0daf, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1007_0db2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0db5, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1007_0db8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_0dbb, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_0dbf, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1007_0dc1, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x1007_0dc4, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1007_0dc7, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1007_0dca, 4); imul(edx, memd[ss, ebp - 0x18]);        /* imul edx, [ebp-0x18] */
            ii(0x1007_0dce, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_0dd1, 4); imul(eax, memd[ss, ebp - 0x1c]);        /* imul eax, [ebp-0x1c] */
            ii(0x1007_0dd5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_0dd7, 3); mov(memd[ss, ebp - 0x20], edx);         /* mov [ebp-0x20], edx */
            ii(0x1007_0dda, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_0ddd, 3); cmp(eax, memd[ss, ebp - 0x14]);         /* cmp eax, [ebp-0x14] */
            ii(0x1007_0de0, 2); if(jle(0x1007_0dee, 0xc)) goto l_0x1007_0dee; /* jle 0x10070dee */
            ii(0x1007_0de2, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_0de9, 5); jmp(0x1007_0ef1, 0x103); goto l_0x1007_0ef1; /* jmp 0x10070ef1 */
        l_0x1007_0dee:
            ii(0x1007_0dee, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0df1, 5); cmp(memw[ds, eax + 0x8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1007_0df6, 2); if(jz(0x1007_0e02, 0xa)) goto l_0x1007_0e02; /* jz 0x10070e02 */
            ii(0x1007_0df8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0dfb, 5); cmp(memw[ds, eax + 0x8], 0x45);         /* cmp word [eax+0x8], 0x45 */
            ii(0x1007_0e00, 2); if(jnz(0x1007_0e04, 0x2)) goto l_0x1007_0e04; /* jnz 0x10070e04 */
        l_0x1007_0e02:
            ii(0x1007_0e02, 2); jmp(0x1007_0e10, 0xc); goto l_0x1007_0e10; /* jmp 0x10070e10 */
        l_0x1007_0e04:
            ii(0x1007_0e04, 7); mov(memd[ss, ebp - 0x24], 0x1);         /* mov dword [ebp-0x24], 0x1 */
            ii(0x1007_0e0b, 5); jmp(0x1007_0ef1, 0xe1); goto l_0x1007_0ef1; /* jmp 0x10070ef1 */
        l_0x1007_0e10:
            ii(0x1007_0e10, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_0e13, 5); call(/* sys */ 0x1016_5df8, 0xf_4fe0);  /* call 0x10165df8 */
            ii(0x1007_0e18, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_0e1a, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_0e1d, 5); call(/* sys */ 0x1016_5df8, 0xf_4fd6);  /* call 0x10165df8 */
            ii(0x1007_0e22, 5); call(0x1007_6e7c, 0x6055);              /* call 0x10076e7c */
            ii(0x1007_0e27, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_0e2a, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_0e2d, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1007_0e31, 2); if(jnz(0x1007_0e3f, 0xc)) goto l_0x1007_0e3f; /* jnz 0x10070e3f */
            ii(0x1007_0e33, 7); mov(memd[ss, ebp - 0x24], 0x1);         /* mov dword [ebp-0x24], 0x1 */
            ii(0x1007_0e3a, 5); jmp(0x1007_0ef1, 0xb2); goto l_0x1007_0ef1; /* jmp 0x10070ef1 */
        l_0x1007_0e3f:
            ii(0x1007_0e3f, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1007_0e42, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1007_0e45, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_0e47, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_0e4a, 3); idiv(memd[ss, ebp - 0x20]);             /* idiv dword [ebp-0x20] */
            ii(0x1007_0e4d, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_0e50, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1007_0e53, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1007_0e56, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_0e58, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_0e5b, 3); idiv(memd[ss, ebp - 0x20]);             /* idiv dword [ebp-0x20] */
            ii(0x1007_0e5e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_0e61, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_0e64, 3); mov(edx, memd[ds, edx + 0x14]);         /* mov edx, [edx+0x14] */
            ii(0x1007_0e67, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_0e6a, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1007_0e6d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_0e70, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_0e72, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_0e75, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_0e78, 3); mov(edx, memd[ds, edx + 0x16]);         /* mov edx, [edx+0x16] */
            ii(0x1007_0e7b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_0e7e, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1007_0e81, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_0e84, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_0e86, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1007_0e89:
            ii(0x1007_0e89, 4); add(memd[ss, ebp - 0x20], -0x1 /* 0xff */); /* add dword [ebp-0x20], 0xffffffff */
            ii(0x1007_0e8d, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1007_0e91, 2); if(jz(0x1007_0eea, 0x57)) goto l_0x1007_0eea; /* jz 0x10070eea */
            ii(0x1007_0e93, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_0e96, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_0e99, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_0e9c, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_0e9f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_0ea2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_0ea5, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_0ea8, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_0eab, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1007_0eaf, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1007_0eb3, 5); call(0x1007_3cfd, 0x2e45);              /* call 0x10073cfd */
            ii(0x1007_0eb8, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1007_0ebb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_0ebd, 4); mov(ax, memw[ss, ebp - 0x38]);          /* mov ax, [ebp-0x38] */
            ii(0x1007_0ec1, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_0ec4, 2); if(jz(0x1007_0ed1, 0xb)) goto l_0x1007_0ed1; /* jz 0x10070ed1 */
            ii(0x1007_0ec6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_0ec8, 4); mov(ax, memw[ss, ebp - 0x38]);          /* mov ax, [ebp-0x38] */
            ii(0x1007_0ecc, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_0ecf, 2); if(jnz(0x1007_0ed3, 0x2)) goto l_0x1007_0ed3; /* jnz 0x10070ed3 */
        l_0x1007_0ed1:
            ii(0x1007_0ed1, 2); jmp(0x1007_0edc, 0x9); goto l_0x1007_0edc; /* jmp 0x10070edc */
        l_0x1007_0ed3:
            ii(0x1007_0ed3, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_0eda, 2); jmp(0x1007_0ef1, 0x15); goto l_0x1007_0ef1; /* jmp 0x10070ef1 */
        l_0x1007_0edc:
            ii(0x1007_0edc, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_0edf, 3); add(memd[ss, ebp - 0x18], eax);         /* add [ebp-0x18], eax */
            ii(0x1007_0ee2, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_0ee5, 3); add(memd[ss, ebp - 0x1c], eax);         /* add [ebp-0x1c], eax */
            ii(0x1007_0ee8, 2); jmp(0x1007_0e89, -0x61); goto l_0x1007_0e89; /* jmp 0x10070e89 */
        l_0x1007_0eea:
            ii(0x1007_0eea, 7); mov(memd[ss, ebp - 0x24], 0x1);         /* mov dword [ebp-0x24], 0x1 */
        l_0x1007_0ef1:
            ii(0x1007_0ef1, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_0ef4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0ef6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_0ef7, 1); pop(edi);                               /* pop edi */
            ii(0x1007_0ef8, 1); pop(esi);                               /* pop esi */
            ii(0x1007_0ef9, 1); ret();                                  /* ret */
        }
    }
}
