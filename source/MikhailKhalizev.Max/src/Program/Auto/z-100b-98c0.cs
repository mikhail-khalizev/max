using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_98c0-c3fb405e")]
        public void Method_100b_98c0()
        {
            ii(0x100b_98c0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_98c5, 5); calld(Definitions.sys_check_available_stack_size, 0xa_c488); /* call 0x10165d52 */
            ii(0x100b_98ca, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_98cb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_98cc, 1); pushd(esi);                             /* push esi */
            ii(0x100b_98cd, 1); pushd(edi);                             /* push edi */
            ii(0x100b_98ce, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_98cf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_98d1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_98d7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_98da, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_98dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_98e0, 4); cmp(memd_a32[ds, eax + 0x63], 0);       /* cmp dword [eax+0x63], 0x0 */
            ii(0x100b_98e4, 2); if(jzd(0x100b_9926, 0x40)) goto l_0x100b_9926; /* jz 0x100b9926 */
            ii(0x100b_98e6, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_98ed, 2); jmpd(0x100b_98f5, 0x6); goto l_0x100b_98f5; /* jmp 0x100b98f5 */
        l_0x100b_98ef:
            ii(0x100b_98ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_98f2, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100b_98f5:
            ii(0x100b_98f5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_98f8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_98fb, 4); cmp(ax, memw_a32[ds, edx + 0x61]);      /* cmp ax, [edx+0x61] */
            ii(0x100b_98ff, 2); if(jged(0x100b_991b, 0x1a)) goto l_0x100b_991b; /* jge 0x100b991b */
            ii(0x100b_9901, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_9905, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_9908, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_990a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_990d, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_9910, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_9912, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_9914, 5); calld(Definitions.sys_delete, 0xa_c64b); /* call 0x10165f64 */
            ii(0x100b_9919, 2); jmpd(0x100b_98ef, -0x2c); goto l_0x100b_98ef; /* jmp 0x100b98ef */
        l_0x100b_991b:
            ii(0x100b_991b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_991e, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_9921, 5); calld(Definitions.sys_delete, 0xa_c63e); /* call 0x10165f64 */
        l_0x100b_9926:
            ii(0x100b_9926, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9929, 4); cmp(memd_a32[ds, eax + 0x67], 0);       /* cmp dword [eax+0x67], 0x0 */
            ii(0x100b_992d, 2); if(jzd(0x100b_996f, 0x40)) goto l_0x100b_996f; /* jz 0x100b996f */
            ii(0x100b_992f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_9936, 2); jmpd(0x100b_993e, 0x6); goto l_0x100b_993e; /* jmp 0x100b993e */
        l_0x100b_9938:
            ii(0x100b_9938, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_993b, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100b_993e:
            ii(0x100b_993e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_9941, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_9944, 4); cmp(ax, memw_a32[ds, edx + 0x61]);      /* cmp ax, [edx+0x61] */
            ii(0x100b_9948, 2); if(jged(0x100b_9964, 0x1a)) goto l_0x100b_9964; /* jge 0x100b9964 */
            ii(0x100b_994a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_994e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_9951, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9953, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9956, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100b_9959, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_995b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_995d, 5); calld(Definitions.sys_delete, 0xa_c602); /* call 0x10165f64 */
            ii(0x100b_9962, 2); jmpd(0x100b_9938, -0x2c); goto l_0x100b_9938; /* jmp 0x100b9938 */
        l_0x100b_9964:
            ii(0x100b_9964, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9967, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100b_996a, 5); calld(Definitions.sys_delete, 0xa_c5f5); /* call 0x10165f64 */
        l_0x100b_996f:
            ii(0x100b_996f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9971, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9974, 5); add(eax, 0xc1);                         /* add eax, 0xc1 */
            ii(0x100b_9979, 5); calld(0x1008_8dcc, -0x3_0bb2);          /* call 0x10088dcc */
            ii(0x100b_997e, 5); sub(eax, 0xc1);                         /* sub eax, 0xc1 */
            ii(0x100b_9983, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9986, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9988, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_998b, 5); add(eax, 0xbd);                         /* add eax, 0xbd */
            ii(0x100b_9990, 5); calld(0x1008_8dcc, -0x3_0bc9);          /* call 0x10088dcc */
            ii(0x100b_9995, 5); sub(eax, 0xbd);                         /* sub eax, 0xbd */
            ii(0x100b_999a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_999d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_999f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_99a2, 5); add(eax, 0xb9);                         /* add eax, 0xb9 */
            ii(0x100b_99a7, 5); calld(0x1008_8dcc, -0x3_0be0);          /* call 0x10088dcc */
            ii(0x100b_99ac, 5); sub(eax, 0xb9);                         /* sub eax, 0xb9 */
            ii(0x100b_99b1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_99b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_99b6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_99b9, 5); add(eax, 0xb5);                         /* add eax, 0xb5 */
            ii(0x100b_99be, 5); calld(0x1008_8dcc, -0x3_0bf7);          /* call 0x10088dcc */
            ii(0x100b_99c3, 5); sub(eax, 0xb5);                         /* sub eax, 0xb5 */
            ii(0x100b_99c8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_99cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_99cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_99d0, 5); add(eax, 0xb1);                         /* add eax, 0xb1 */
            ii(0x100b_99d5, 5); calld(0x1008_8dcc, -0x3_0c0e);          /* call 0x10088dcc */
            ii(0x100b_99da, 5); sub(eax, 0xb1);                         /* sub eax, 0xb1 */
            ii(0x100b_99df, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_99e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_99e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_99e7, 5); add(eax, 0xad);                         /* add eax, 0xad */
            ii(0x100b_99ec, 5); calld(0x1008_8dcc, -0x3_0c25);          /* call 0x10088dcc */
            ii(0x100b_99f1, 5); sub(eax, 0xad);                         /* sub eax, 0xad */
            ii(0x100b_99f6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_99f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_99fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_99fe, 5); add(eax, 0xa9);                         /* add eax, 0xa9 */
            ii(0x100b_9a03, 5); calld(0x1008_8dcc, -0x3_0c3c);          /* call 0x10088dcc */
            ii(0x100b_9a08, 5); sub(eax, 0xa9);                         /* sub eax, 0xa9 */
            ii(0x100b_9a0d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a10, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a15, 5); add(eax, 0xa5);                         /* add eax, 0xa5 */
            ii(0x100b_9a1a, 5); calld(0x1008_8dcc, -0x3_0c53);          /* call 0x10088dcc */
            ii(0x100b_9a1f, 5); sub(eax, 0xa5);                         /* sub eax, 0xa5 */
            ii(0x100b_9a24, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a2c, 5); add(eax, 0xa1);                         /* add eax, 0xa1 */
            ii(0x100b_9a31, 5); calld(0x1008_8dcc, -0x3_0c6a);          /* call 0x10088dcc */
            ii(0x100b_9a36, 5); sub(eax, 0xa1);                         /* sub eax, 0xa1 */
            ii(0x100b_9a3b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a43, 5); add(eax, 0x9d);                         /* add eax, 0x9d */
            ii(0x100b_9a48, 5); calld(0x1008_8dcc, -0x3_0c81);          /* call 0x10088dcc */
            ii(0x100b_9a4d, 5); sub(eax, 0x9d);                         /* sub eax, 0x9d */
            ii(0x100b_9a52, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a57, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a5a, 5); add(eax, 0x99);                         /* add eax, 0x99 */
            ii(0x100b_9a5f, 5); calld(0x1008_8dcc, -0x3_0c98);          /* call 0x10088dcc */
            ii(0x100b_9a64, 5); sub(eax, 0x99);                         /* sub eax, 0x99 */
            ii(0x100b_9a69, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a71, 5); add(eax, 0x95);                         /* add eax, 0x95 */
            ii(0x100b_9a76, 5); calld(0x1008_8dcc, -0x3_0caf);          /* call 0x10088dcc */
            ii(0x100b_9a7b, 5); sub(eax, 0x95);                         /* sub eax, 0x95 */
            ii(0x100b_9a80, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a88, 5); add(eax, 0x91);                         /* add eax, 0x91 */
            ii(0x100b_9a8d, 5); calld(0x1008_8dcc, -0x3_0cc6);          /* call 0x10088dcc */
            ii(0x100b_9a92, 5); sub(eax, 0x91);                         /* sub eax, 0x91 */
            ii(0x100b_9a97, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9a9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9a9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9a9f, 5); add(eax, 0x8d);                         /* add eax, 0x8d */
            ii(0x100b_9aa4, 5); calld(0x1008_8dcc, -0x3_0cdd);          /* call 0x10088dcc */
            ii(0x100b_9aa9, 5); sub(eax, 0x8d);                         /* sub eax, 0x8d */
            ii(0x100b_9aae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9ab1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9ab3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9ab6, 5); add(eax, 0x89);                         /* add eax, 0x89 */
            ii(0x100b_9abb, 5); calld(0x1008_8dcc, -0x3_0cf4);          /* call 0x10088dcc */
            ii(0x100b_9ac0, 5); sub(eax, 0x89);                         /* sub eax, 0x89 */
            ii(0x100b_9ac5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9ac8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9aca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9acd, 5); add(eax, 0x85);                         /* add eax, 0x85 */
            ii(0x100b_9ad2, 5); calld(0x1008_8dcc, -0x3_0d0b);          /* call 0x10088dcc */
            ii(0x100b_9ad7, 5); sub(eax, 0x85);                         /* sub eax, 0x85 */
            ii(0x100b_9adc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9adf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9ae1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9ae4, 5); add(eax, 0x81);                         /* add eax, 0x81 */
            ii(0x100b_9ae9, 5); calld(0x1008_8dcc, -0x3_0d22);          /* call 0x10088dcc */
            ii(0x100b_9aee, 5); sub(eax, 0x81);                         /* sub eax, 0x81 */
            ii(0x100b_9af3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9af6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9af8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9afb, 3); add(eax, 0x7d);                         /* add eax, 0x7d */
            ii(0x100b_9afe, 5); calld(0x1008_8dcc, -0x3_0d37);          /* call 0x10088dcc */
            ii(0x100b_9b03, 3); sub(eax, 0x7d);                         /* sub eax, 0x7d */
            ii(0x100b_9b06, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b0e, 3); add(eax, 0x6d);                         /* add eax, 0x6d */
            ii(0x100b_9b11, 5); calld(0x100c_a514, 0x1_09fe);           /* call 0x100ca514 */
            ii(0x100b_9b16, 3); sub(eax, 0x6d);                         /* sub eax, 0x6d */
            ii(0x100b_9b19, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b21, 3); add(eax, 0x57);                         /* add eax, 0x57 */
            ii(0x100b_9b24, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x3_0eed); /* call 0x10088c3c */
            ii(0x100b_9b29, 3); sub(eax, 0x57);                         /* sub eax, 0x57 */
            ii(0x100b_9b2c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b2f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b34, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100b_9b37, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x3_0f00); /* call 0x10088c3c */
            ii(0x100b_9b3c, 3); sub(eax, 0x4d);                         /* sub eax, 0x4d */
            ii(0x100b_9b3f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b42, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b44, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b47, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_9b4a, 5); calld(0x100c_a628, 0x1_0ad9);           /* call 0x100ca628 */
            ii(0x100b_9b4f, 3); sub(eax, 0x43);                         /* sub eax, 0x43 */
            ii(0x100b_9b52, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b57, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b5a, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x100b_9b5d, 5); calld(0x100c_a124, 0x1_05c2);           /* call 0x100ca124 */
            ii(0x100b_9b62, 3); sub(eax, 0x37);                         /* sub eax, 0x37 */
            ii(0x100b_9b65, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b6d, 3); add(eax, 0x33);                         /* add eax, 0x33 */
            ii(0x100b_9b70, 5); calld(0x100c_a454, 0x1_08df);           /* call 0x100ca454 */
            ii(0x100b_9b75, 3); sub(eax, 0x33);                         /* sub eax, 0x33 */
            ii(0x100b_9b78, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b7d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b80, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x100b_9b83, 5); calld(0x1009_b834, -0x1_e354);          /* call 0x1009b834 */
            ii(0x100b_9b88, 3); sub(eax, 0x29);                         /* sub eax, 0x29 */
            ii(0x100b_9b8b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9b8e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9b90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9b93, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x100b_9b96, 5); calld(0x1008_8b7c, -0x3_101f);          /* call 0x10088b7c */
            ii(0x100b_9b9b, 3); sub(eax, 0x25);                         /* sub eax, 0x25 */
            ii(0x100b_9b9e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9ba1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9ba3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9ba6, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100b_9ba9, 5); calld(0x1008_8b7c, -0x3_1032);          /* call 0x10088b7c */
            ii(0x100b_9bae, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x100b_9bb1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9bb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9bb6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9bb9, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x100b_9bbc, 5); calld(0x1008_8b7c, -0x3_1045);          /* call 0x10088b7c */
            ii(0x100b_9bc1, 3); sub(eax, 0x1d);                         /* sub eax, 0x1d */
            ii(0x100b_9bc4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9bc7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9bc9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9bcc, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_9bcf, 5); calld(0x1008_8b7c, -0x3_1058);          /* call 0x10088b7c */
            ii(0x100b_9bd4, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100b_9bd7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9bda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9bdc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9bdf, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_9be2, 5); calld(0x100c_a414, 0x1_082d);           /* call 0x100ca414 */
            ii(0x100b_9be7, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x100b_9bea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9bed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9bef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9bf2, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x100b_9bf5, 5); calld(0x100c_a414, 0x1_081a);           /* call 0x100ca414 */
            ii(0x100b_9bfa, 3); sub(eax, 0x11);                         /* sub eax, 0x11 */
            ii(0x100b_9bfd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9c00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9c03, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_9c06, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_9c09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_9c0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_9c0c, 1); popd(edi);                              /* pop edi */
            ii(0x100b_9c0d, 1); popd(esi);                              /* pop esi */
            ii(0x100b_9c0e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_9c0f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_9c10, 1); retd(); return;                         /* ret */
        }
    }
}
