using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4bed-c8a725b0")]
        public void Method_100f_4bed()
        {
            ii(0x100f_4bed, 5); push(0xac);                             /* push 0xac */
            ii(0x100f_4bf2, 5); call(Definitions.sys_check_available_stack_size, 0x7_115b); /* call 0x10165d52 */
            ii(0x100f_4bf7, 1); push(ebx);                              /* push ebx */
            ii(0x100f_4bf8, 1); push(ecx);                              /* push ecx */
            ii(0x100f_4bf9, 1); push(edx);                              /* push edx */
            ii(0x100f_4bfa, 1); push(esi);                              /* push esi */
            ii(0x100f_4bfb, 1); push(edi);                              /* push edi */
            ii(0x100f_4bfc, 1); push(ebp);                              /* push ebp */
            ii(0x100f_4bfd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4bff, 6); sub(esp, 0x7c);                         /* sub esp, 0x7c */
            ii(0x100f_4c05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4c07, 5); mov(eax, memd[ds, 0x101b_87df]);        /* mov eax, [0x101b87df] */
            ii(0x100f_4c0c, 5); call(0x100c_fb73, -0x2_509e);           /* call 0x100cfb73 */
            ii(0x100f_4c11, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_4c18, 2); if(jz(0x100f_4c40, 0x26)) goto l_0x100f_4c40; /* jz 0x100f4c40 */
            ii(0x100f_4c1a, 5); call(0x100f_fc13, 0xaff4);              /* call 0x100ffc13 */
            ii(0x100f_4c1f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4c21, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_4c26, 1); cwde();                                 /* cwde */
            ii(0x100f_4c27, 5); call(0x100d_607a, -0x1_ebb2);           /* call 0x100d607a */
            ii(0x100f_4c2c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_4c31, 5); call(0x1007_65d0, -0x7_e666);           /* call 0x100765d0 */
            ii(0x100f_4c36, 5); call(0x100f_fa70, 0xae35);              /* call 0x100ffa70 */
            ii(0x100f_4c3b, 5); jmp(0x100f_4db1, 0x171); goto l_0x100f_4db1; /* jmp 0x100f4db1 */
        l_0x100f_4c40:
            ii(0x100f_4c40, 8); cmp(memw[ds, 0x101c_3982], 0);          /* cmp word [0x101c3982], 0x0 */
            ii(0x100f_4c48, 6); if(jz(0x100f_4db1, 0x163)) goto l_0x100f_4db1; /* jz 0x100f4db1 */
            ii(0x100f_4c4e, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_4c53, 5); call(0x1007_5fdc, -0x7_ec7c);           /* call 0x10075fdc */
            ii(0x100f_4c58, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_4c5b, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_4c5f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_4c62, 6); push(memd[ds, eax + 0x101b_d42c]);      /* push dword [eax+0x101bd42c] */
            ii(0x100f_4c68, 5); mov(eax, memd[ds, 0x101c_3980]);        /* mov eax, [0x101c3980] */
            ii(0x100f_4c6d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_4c70, 1); push(eax);                              /* push eax */
            ii(0x100f_4c71, 5); mov(eax, 0x101c_3f00);                  /* mov eax, 0x101c3f00 */
            ii(0x100f_4c76, 1); push(eax);                              /* push eax */
            ii(0x100f_4c77, 5); mov(eax, StringDefinitions.SdescrIS2);  /* mov eax, 0x101a252c */
            ii(0x100f_4c7c, 1); push(eax);                              /* push eax */
            ii(0x100f_4c7d, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x100f_4c80, 1); push(eax);                              /* push eax */
            ii(0x100f_4c81, 5); call(Definitions.sys_sprintf, 0x7_127b); /* call 0x10165f01 */
            ii(0x100f_4c86, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100f_4c89, 5); mov(edx, StringDefinitions.Rt3);        /* mov edx, 0x101a2539 */
            ii(0x100f_4c8e, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x100f_4c91, 5); call(Definitions.my_fopen, -0x5877);    /* call 0x100ef41f */
            ii(0x100f_4c96, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100f_4c99, 4); cmp(memd[ss, ebp - 0x6c], 0);           /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100f_4c9d, 6); if(jz(0x100f_4db1, 0x10e)) goto l_0x100f_4db1; /* jz 0x100f4db1 */
            ii(0x100f_4ca3, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100f_4ca8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4caa, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100f_4cad, 5); call(Definitions.my_fseek, -0x585d);    /* call 0x100ef455 */
            ii(0x100f_4cb2, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100f_4cb5, 5); call(Definitions.sys_ftell, 0x7_da8d);  /* call 0x10172747 */
            ii(0x100f_4cba, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x100f_4cbd, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_4cc1, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_4cc4, 2); if(jnz(0x100f_4cdc, 0x16)) goto l_0x100f_4cdc; /* jnz 0x100f4cdc */
            ii(0x100f_4cc6, 5); mov(eax, memd[ds, 0x101c_3980]);        /* mov eax, [0x101c3980] */
            ii(0x100f_4ccb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_4cce, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_4cd1, 6); mov(eax, memd[ds, eax + 0x101b_d368]);  /* mov eax, [eax+0x101bd368] */
            ii(0x100f_4cd7, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100f_4cda, 2); jmp(0x100f_4d0f, 0x33); goto l_0x100f_4d0f; /* jmp 0x100f4d0f */
        l_0x100f_4cdc:
            ii(0x100f_4cdc, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_4ce0, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100f_4ce3, 2); if(jnz(0x100f_4cfb, 0x16)) goto l_0x100f_4cfb; /* jnz 0x100f4cfb */
            ii(0x100f_4ce5, 5); mov(eax, memd[ds, 0x101c_3980]);        /* mov eax, [0x101c3980] */
            ii(0x100f_4cea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_4ced, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_4cf0, 6); mov(eax, memd[ds, eax + 0x101b_d3a4]);  /* mov eax, [eax+0x101bd3a4] */
            ii(0x100f_4cf6, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100f_4cf9, 2); jmp(0x100f_4d0f, 0x14); goto l_0x100f_4d0f; /* jmp 0x100f4d0f */
        l_0x100f_4cfb:
            ii(0x100f_4cfb, 5); mov(eax, memd[ds, 0x101c_3980]);        /* mov eax, [0x101c3980] */
            ii(0x100f_4d00, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_4d03, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_4d06, 6); mov(eax, memd[ds, eax + 0x101b_d404]);  /* mov eax, [eax+0x101bd404] */
            ii(0x100f_4d0c, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
        l_0x100f_4d0f:
            ii(0x100f_4d0f, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x100f_4d12, 5); call(Definitions.sys_strlen, 0x7_d1b0); /* call 0x10171ec7 */
            ii(0x100f_4d17, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100f_4d1c, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x100f_4d1f, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x100f_4d23, 3); add(eax, memd[ss, ebp - 0x74]);         /* add eax, [ebp-0x74] */
            ii(0x100f_4d26, 3); add(eax, 0x5);                          /* add eax, 0x5 */
            ii(0x100f_4d29, 5); call(Definitions.sys_new_arr, 0x7_12e2); /* call 0x10166010 */
            ii(0x100f_4d2e, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x100f_4d31, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x100f_4d35, 3); add(eax, memd[ss, ebp - 0x74]);         /* add eax, [ebp-0x74] */
            ii(0x100f_4d38, 3); lea(ebx, memd[ds, eax + 0x5]);          /* lea ebx, [eax+0x5] */
            ii(0x100f_4d3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4d3d, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100f_4d40, 5); call(Definitions.sys_memset, 0x7_109b); /* call 0x10165de0 */
            ii(0x100f_4d45, 3); mov(edx, memd[ss, ebp - 0x78]);         /* mov edx, [ebp-0x78] */
            ii(0x100f_4d48, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100f_4d4b, 5); call(Definitions.sys_strcpy, 0x7_117f); /* call 0x10165ecf */
            ii(0x100f_4d50, 5); mov(edx, StringDefinitions.Control25);  /* mov edx, 0x101a253c */
            ii(0x100f_4d55, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100f_4d58, 5); call(Definitions.sys_strcat, 0x7_11d4); /* call 0x10165f31 */
            ii(0x100f_4d5d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_4d5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4d61, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100f_4d64, 5); call(Definitions.my_fseek, -0x5914);    /* call 0x100ef455 */
            ii(0x100f_4d69, 3); mov(ecx, memd[ss, ebp - 0x6c]);         /* mov ecx, [ebp-0x6c] */
            ii(0x100f_4d6c, 3); mov(ebx, memd[ss, ebp - 0x74]);         /* mov ebx, [ebp-0x74] */
            ii(0x100f_4d6f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_4d74, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x100f_4d78, 3); add(eax, memd[ss, ebp - 0x7c]);         /* add eax, [ebp-0x7c] */
            ii(0x100f_4d7b, 5); call(Definitions.my_fread, -0x58f1);    /* call 0x100ef48f */
            ii(0x100f_4d80, 5); call(0x100c_aa00, -0x2_a385);           /* call 0x100caa00 */
            ii(0x100f_4d85, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_4d8a, 1); push(eax);                              /* push eax */
            ii(0x100f_4d8b, 5); call(0x100c_aa20, -0x2_a370);           /* call 0x100caa20 */
            ii(0x100f_4d90, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_4d92, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_4d97, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4d99, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100f_4d9c, 5); call(0x1011_5d23, 0x2_0f82);            /* call 0x10115d23 */
            ii(0x100f_4da1, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100f_4da4, 5); call(Definitions.sys_delete, 0x7_11bb); /* call 0x10165f64 */
            ii(0x100f_4da9, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100f_4dac, 5); call(Definitions.sys_fclose, 0x7_d2b8); /* call 0x10172069 */
        l_0x100f_4db1:
            ii(0x100f_4db1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4db3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_4db4, 1); pop(edi);                               /* pop edi */
            ii(0x100f_4db5, 1); pop(esi);                               /* pop esi */
            ii(0x100f_4db6, 1); pop(edx);                               /* pop edx */
            ii(0x100f_4db7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_4db8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_4db9, 1); ret();                                  /* ret */
        }
    }
}
