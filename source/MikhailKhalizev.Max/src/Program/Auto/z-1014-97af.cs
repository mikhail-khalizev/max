using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_97af-3e9345c1")]
        public void Method_1014_97af()
        {
            ii(0x1014_97af, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_97b4, 5); call(Definitions.sys_check_available_stack_size, 0x1_c599); /* call 0x10165d52 */
            ii(0x1014_97b9, 1); push(ebx);                              /* push ebx */
            ii(0x1014_97ba, 1); push(ecx);                              /* push ecx */
            ii(0x1014_97bb, 1); push(esi);                              /* push esi */
            ii(0x1014_97bc, 1); push(edi);                              /* push edi */
            ii(0x1014_97bd, 1); push(ebp);                              /* push ebp */
            ii(0x1014_97be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_97c0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_97c6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_97c9, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_97cc, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_97d3, 2); if(jz(0x1014_97ec, 0x17)) goto l_0x1014_97ec; /* jz 0x101497ec */
            ii(0x1014_97d5, 5); mov(edx, 0x101b_6340);                  /* mov edx, 0x101b6340 */
            ii(0x1014_97da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_97dd, 5); call(Definitions.sys_call_dtor_arr, 0x1_c7d6); /* call 0x10165fb8 */
            ii(0x1014_97e2, 5); call(Definitions.sys_delete_arr, 0x1_c7f1); /* call 0x10165fd8 */
            ii(0x1014_97e7, 5); jmp(0x1014_98e0, 0xf4); goto l_0x1014_98e0; /* jmp 0x101498e0 */
        l_0x1014_97ec:
            ii(0x1014_97ec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_97ef, 7); mov(memd[ds, eax + 2], 0x101b_7398);    /* mov dword [eax+0x2], 0x101b7398 */
            ii(0x1014_97f6, 7); dec(memw[ds, 0x101c_8148]);             /* dec word [0x101c8148] */
            ii(0x1014_97fd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_9800, 7); cmp(memd[ds, eax + 167], 0);            /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_9807, 2); if(jz(0x1014_9817, 0xe)) goto l_0x1014_9817; /* jz 0x10149817 */
            ii(0x1014_9809, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_980c, 6); mov(eax, memd[ds, eax + 167]);          /* mov eax, [eax+0xa7] */
            ii(0x1014_9812, 5); call(Definitions.sys_delete, 0x1_c74d); /* call 0x10165f64 */
        l_0x1014_9817:
            ii(0x1014_9817, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_9819, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_981c, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_9821, 5); call(0x1009_b834, -0xa_dff2);           /* call 0x1009b834 */
            ii(0x1014_9826, 5); sub(eax, 0x94);                         /* sub eax, 0x94 */
            ii(0x1014_982b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_982e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_9830, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_9833, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1014_9838, 5); call(0x1009_b834, -0xa_e009);           /* call 0x1009b834 */
            ii(0x1014_983d, 5); sub(eax, 0x8a);                         /* sub eax, 0x8a */
            ii(0x1014_9842, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_9845, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_9847, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_984a, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_984f, 5); call(0x1007_5f2c, -0xd_3928);           /* call 0x10075f2c */
            ii(0x1014_9854, 5); sub(eax, 0x86);                         /* sub eax, 0x86 */
            ii(0x1014_9859, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_985c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_985e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_9861, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_9866, 5); call(0x1007_5f2c, -0xd_393f);           /* call 0x10075f2c */
            ii(0x1014_986b, 5); sub(eax, 0x82);                         /* sub eax, 0x82 */
            ii(0x1014_9870, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_9873, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_9875, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_9878, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_987b, 5); call(0x1008_8b04, -0xc_0d7c);           /* call 0x10088b04 */
            ii(0x1014_9880, 3); sub(eax, 0x74);                         /* sub eax, 0x74 */
            ii(0x1014_9883, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_9886, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_9888, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_988b, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_988e, 5); call(0x1007_5eac, -0xd_39e7);           /* call 0x10075eac */
            ii(0x1014_9893, 3); sub(eax, 0x70);                         /* sub eax, 0x70 */
            ii(0x1014_9896, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_9899, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_989b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_989e, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_98a1, 5); call(0x1007_5eec, -0xd_39ba);           /* call 0x10075eec */
            ii(0x1014_98a6, 3); sub(eax, 0x6c);                         /* sub eax, 0x6c */
            ii(0x1014_98a9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_98ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_98ae, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_98b1, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_98b4, 5); call(0x1012_030c, -0x2_95ad);           /* call 0x1012030c */
            ii(0x1014_98b9, 3); sub(eax, 0x65);                         /* sub eax, 0x65 */
            ii(0x1014_98bc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_98bf, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_98c4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_98c7, 5); call(0x100c_a200, -0x7_f6cc);           /* call 0x100ca200 */
            ii(0x1014_98cc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_98cf, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_98d6, 2); if(jz(0x1014_98e0, 8)) goto l_0x1014_98e0; /* jz 0x101498e0 */
            ii(0x1014_98d8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_98db, 5); call(Definitions.sys_delete, 0x1_c684); /* call 0x10165f64 */
        l_0x1014_98e0:
            ii(0x1014_98e0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_98e3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_98e6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_98e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_98eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_98ec, 1); pop(edi);                               /* pop edi */
            ii(0x1014_98ed, 1); pop(esi);                               /* pop esi */
            ii(0x1014_98ee, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_98ef, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_98f0, 1); ret();                                  /* ret */
        }
    }
}
