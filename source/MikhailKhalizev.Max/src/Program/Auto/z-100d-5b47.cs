using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5b47-863d39e8")]
        public void Method_100d_5b47()
        {
            ii(0x100d_5b47, 5); push(0x50);                             /* push 0x50 */
            ii(0x100d_5b4c, 5); call(Definitions.sys_check_available_stack_size, 0x9_0201); /* call 0x10165d52 */
            ii(0x100d_5b51, 1); push(ebx);                              /* push ebx */
            ii(0x100d_5b52, 1); push(ecx);                              /* push ecx */
            ii(0x100d_5b53, 1); push(esi);                              /* push esi */
            ii(0x100d_5b54, 1); push(edi);                              /* push edi */
            ii(0x100d_5b55, 1); push(ebp);                              /* push ebp */
            ii(0x100d_5b56, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5b58, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100d_5b5e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_5b61, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_5b64, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_5b6b, 2); if(jz(0x100d_5b84, 0x17)) goto l_0x100d_5b84; /* jz 0x100d5b84 */
            ii(0x100d_5b6d, 5); mov(edx, 0x101b_5d14);                  /* mov edx, 0x101b5d14 */
            ii(0x100d_5b72, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5b75, 5); call(Definitions.sys_call_dtor_arr, 0x9_043e); /* call 0x10165fb8 */
            ii(0x100d_5b7a, 5); call(Definitions.sys_delete_arr, 0x9_0459); /* call 0x10165fd8 */
            ii(0x100d_5b7f, 5); jmp(0x100d_5cac, 0x128); goto l_0x100d_5cac; /* jmp 0x100d5cac */
        l_0x100d_5b84:
            ii(0x100d_5b84, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5b87, 7); mov(memd[ds, eax + 19], 0x101b_5d28);   /* mov dword [eax+0x13], 0x101b5d28 */
            ii(0x100d_5b8e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5b91, 3); mov(eax, memd[ds, eax + 50]);           /* mov eax, [eax+0x32] */
            ii(0x100d_5b94, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100d_5b97, 4); cmp(memd[ss, ebp - 44], 0);             /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100d_5b9b, 2); if(jz(0x100d_5bb1, 0x14)) goto l_0x100d_5bb1; /* jz 0x100d5bb1 */
            ii(0x100d_5b9d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5b9f, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100d_5ba2, 5); call(Definitions.my_dtor_d2, -0x766f);  /* call 0x100ce538 */
            ii(0x100d_5ba7, 5); call(Definitions.sys_delete, 0x9_03b8); /* call 0x10165f64 */
            ii(0x100d_5bac, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100d_5baf, 2); jmp(0x100d_5bb8, 7); goto l_0x100d_5bb8; /* jmp 0x100d5bb8 */
        l_0x100d_5bb1:
            ii(0x100d_5bb1, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
        l_0x100d_5bb8:
            ii(0x100d_5bb8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5bbb, 3); mov(eax, memd[ds, eax + 54]);           /* mov eax, [eax+0x36] */
            ii(0x100d_5bbe, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100d_5bc1, 4); cmp(memd[ss, ebp - 40], 0);             /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_5bc5, 2); if(jz(0x100d_5bdb, 0x14)) goto l_0x100d_5bdb; /* jz 0x100d5bdb */
            ii(0x100d_5bc7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5bc9, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_5bcc, 5); call(Definitions.my_dtor_d2, -0x7699);  /* call 0x100ce538 */
            ii(0x100d_5bd1, 5); call(Definitions.sys_delete, 0x9_038e); /* call 0x10165f64 */
            ii(0x100d_5bd6, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100d_5bd9, 2); jmp(0x100d_5be2, 7); goto l_0x100d_5be2; /* jmp 0x100d5be2 */
        l_0x100d_5bdb:
            ii(0x100d_5bdb, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
        l_0x100d_5be2:
            ii(0x100d_5be2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5be5, 3); mov(eax, memd[ds, eax + 58]);           /* mov eax, [eax+0x3a] */
            ii(0x100d_5be8, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100d_5beb, 4); cmp(memd[ss, ebp - 36], 0);             /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100d_5bef, 2); if(jz(0x100d_5c05, 0x14)) goto l_0x100d_5c05; /* jz 0x100d5c05 */
            ii(0x100d_5bf1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5bf3, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100d_5bf6, 5); call(Definitions.my_dtor_d2, -0x76c3);  /* call 0x100ce538 */
            ii(0x100d_5bfb, 5); call(Definitions.sys_delete, 0x9_0364); /* call 0x10165f64 */
            ii(0x100d_5c00, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100d_5c03, 2); jmp(0x100d_5c0c, 7); goto l_0x100d_5c0c; /* jmp 0x100d5c0c */
        l_0x100d_5c05:
            ii(0x100d_5c05, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x100d_5c0c:
            ii(0x100d_5c0c, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_5c13, 2); jmp(0x100d_5c1b, 6); goto l_0x100d_5c1b; /* jmp 0x100d5c1b */
        l_0x100d_5c15:
            ii(0x100d_5c15, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_5c18, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x100d_5c1b:
            ii(0x100d_5c1b, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100d_5c1f, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100d_5c22, 2); if(jge(0x100d_5c57, 0x33)) goto l_0x100d_5c57; /* jge 0x100d5c57 */
            ii(0x100d_5c24, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100d_5c28, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_5c2b, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100d_5c2e, 3); mov(eax, memd[ds, eax + 62]);           /* mov eax, [eax+0x3e] */
            ii(0x100d_5c31, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100d_5c34, 4); cmp(memd[ss, ebp - 48], 0);             /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100d_5c38, 2); if(jz(0x100d_5c4e, 0x14)) goto l_0x100d_5c4e; /* jz 0x100d5c4e */
            ii(0x100d_5c3a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5c3c, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100d_5c3f, 5); call(Definitions.my_dtor_d2, -0x770c);  /* call 0x100ce538 */
            ii(0x100d_5c44, 5); call(Definitions.sys_delete, 0x9_031b); /* call 0x10165f64 */
            ii(0x100d_5c49, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100d_5c4c, 2); jmp(0x100d_5c55, 7); goto l_0x100d_5c55; /* jmp 0x100d5c55 */
        l_0x100d_5c4e:
            ii(0x100d_5c4e, 7); mov(memd[ss, ebp - 52], 0);             /* mov dword [ebp-0x34], 0x0 */
        l_0x100d_5c55:
            ii(0x100d_5c55, 2); jmp(0x100d_5c15, -0x42); goto l_0x100d_5c15; /* jmp 0x100d5c15 */
        l_0x100d_5c57:
            ii(0x100d_5c57, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5c5a, 3); mov(eax, memd[ds, eax + 78]);           /* mov eax, [eax+0x4e] */
            ii(0x100d_5c5d, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100d_5c60, 4); cmp(memd[ss, ebp - 32], 0);             /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100d_5c64, 2); if(jz(0x100d_5c7a, 0x14)) goto l_0x100d_5c7a; /* jz 0x100d5c7a */
            ii(0x100d_5c66, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5c68, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100d_5c6b, 5); call(Definitions.my_dtor_d6, 0x1_5467); /* call 0x100eb0d7 */
            ii(0x100d_5c70, 5); call(Definitions.sys_delete, 0x9_02ef); /* call 0x10165f64 */
            ii(0x100d_5c75, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100d_5c78, 2); jmp(0x100d_5c81, 7); goto l_0x100d_5c81; /* jmp 0x100d5c81 */
        l_0x100d_5c7a:
            ii(0x100d_5c7a, 7); mov(memd[ss, ebp - 56], 0);             /* mov dword [ebp-0x38], 0x0 */
        l_0x100d_5c81:
            ii(0x100d_5c81, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_5c86, 5); call(0x1010_0efe, 0x2_b273);            /* call 0x10100efe */
            ii(0x100d_5c8b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_5c90, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5c93, 5); call(0x100d_6999, 0xd01);               /* call 0x100d6999 */
            ii(0x100d_5c98, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_5c9b, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_5ca2, 2); if(jz(0x100d_5cac, 8)) goto l_0x100d_5cac; /* jz 0x100d5cac */
            ii(0x100d_5ca4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5ca7, 5); call(Definitions.sys_delete, 0x9_02b8); /* call 0x10165f64 */
        l_0x100d_5cac:
            ii(0x100d_5cac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5caf, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_5cb2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_5cb5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5cb7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_5cb8, 1); pop(edi);                               /* pop edi */
            ii(0x100d_5cb9, 1); pop(esi);                               /* pop esi */
            ii(0x100d_5cba, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_5cbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_5cbc, 1); ret();                                  /* ret */
        }
    }
}
