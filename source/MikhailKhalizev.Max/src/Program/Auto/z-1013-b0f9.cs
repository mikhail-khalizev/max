using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b0f9-94461dc7")]
        public void Method_1013_b0f9()
        {
            ii(0x1013_b0f9, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1013_b0fe, 5); call(Definitions.sys_check_available_stack_size, 0x2_ac4f); /* call 0x10165d52 */
            ii(0x1013_b103, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b104, 1); push(esi);                              /* push esi */
            ii(0x1013_b105, 1); push(edi);                              /* push edi */
            ii(0x1013_b106, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b107, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b109, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_b10f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_b112, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_b115, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_b118, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b11b, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x1013_b11f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b122, 3); cmp(dx, memw[ds, eax]);                 /* cmp dx, [eax] */
            ii(0x1013_b125, 6); if(jnz(0x1013_b1cd, 0xa2)) goto l_0x1013_b1cd; /* jnz 0x1013b1cd */
            ii(0x1013_b12b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b12e, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_b130, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_b133, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b136, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_b139, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_b13b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_b13e, 5); mov(ebx, 0x101b_6edc);                  /* mov ebx, 0x101b6edc */
            ii(0x1013_b143, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1013_b146, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_b149, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b14c, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_b14f, 5); call(Definitions.sys_new_arr, 0x2_aebc); /* call 0x10166010 */
            ii(0x1013_b154, 5); call(Definitions.sys_call_ctor_arr, 0x3_6ca6); /* call 0x10171dff */
            ii(0x1013_b159, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_b15c, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_b163, 2); jmp(0x1013_b16b, 0x6); goto l_0x1013_b16b; /* jmp 0x1013b16b */
        l_0x1013_b165:
            ii(0x1013_b165, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b168, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1013_b16b:
            ii(0x1013_b16b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b16e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_b171, 4); cmp(ax, memw[ds, edx + 0x4]);           /* cmp ax, [edx+0x4] */
            ii(0x1013_b175, 2); if(jge(0x1013_b199, 0x22)) goto l_0x1013_b199; /* jge 0x1013b199 */
            ii(0x1013_b177, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_b17b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b17e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_b180, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b183, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1013_b186, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_b188, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_b18c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b18f, 3); add(eax, memd[ss, ebp - 0x18]);         /* add eax, [ebp-0x18] */
            ii(0x1013_b192, 5); call(0x1013_acc5, -0x4d2);              /* call 0x1013acc5 */
            ii(0x1013_b197, 2); jmp(0x1013_b165, -0x34); goto l_0x1013_b165; /* jmp 0x1013b165 */
        l_0x1013_b199:
            ii(0x1013_b199, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b19c, 4); cmp(memd[ds, eax + 0x6], 0);            /* cmp dword [eax+0x6], 0x0 */
            ii(0x1013_b1a0, 2); if(jz(0x1013_b1b7, 0x15)) goto l_0x1013_b1b7; /* jz 0x1013b1b7 */
            ii(0x1013_b1a2, 5); mov(edx, 0x101b_6edc);                  /* mov edx, 0x101b6edc */
            ii(0x1013_b1a7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b1aa, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1013_b1ad, 5); call(Definitions.sys_call_dtor_arr, 0x2_ae06); /* call 0x10165fb8 */
            ii(0x1013_b1b2, 5); call(Definitions.sys_delete_arr, 0x2_ae21); /* call 0x10165fd8 */
        l_0x1013_b1b7:
            ii(0x1013_b1b7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_b1ba, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_b1bd, 3); mov(memd[ds, edx + 0x6], eax);          /* mov [edx+0x6], eax */
            ii(0x1013_b1c0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b1c3, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1013_b1c7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b1ca, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
        l_0x1013_b1cd:
            ii(0x1013_b1cd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_b1d0, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_b1d3, 4); cmp(ax, memw[ds, edx + 0x4]);           /* cmp ax, [edx+0x4] */
            ii(0x1013_b1d7, 2); if(jle(0x1013_b1e3, 0xa)) goto l_0x1013_b1e3; /* jle 0x1013b1e3 */
            ii(0x1013_b1d9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b1dc, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x1013_b1e0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1013_b1e3:
            ii(0x1013_b1e3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b1e6, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x1013_b1ea, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_b1ed, 2); jmp(0x1013_b1f5, 0x6); goto l_0x1013_b1f5; /* jmp 0x1013b1f5 */
        l_0x1013_b1ef:
            ii(0x1013_b1ef, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b1f2, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
        l_0x1013_b1f5:
            ii(0x1013_b1f5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b1f8, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1013_b1fc, 2); if(jle(0x1013_b228, 0x2a)) goto l_0x1013_b228; /* jle 0x1013b228 */
            ii(0x1013_b1fe, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1013_b202, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_b205, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b208, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1013_b20b, 3); sub(edx, 0x4);                          /* sub edx, 0x4 */
            ii(0x1013_b20e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_b210, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_b214, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b217, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_b219, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b21c, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1013_b21f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_b221, 5); call(0x1013_acc5, -0x561);              /* call 0x1013acc5 */
            ii(0x1013_b226, 2); jmp(0x1013_b1ef, -0x39); goto l_0x1013_b1ef; /* jmp 0x1013b1ef */
        l_0x1013_b228:
            ii(0x1013_b228, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_b22b, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_b22f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b232, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_b234, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b237, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1013_b23a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_b23c, 5); call(0x1013_ac7d, -0x5c4);              /* call 0x1013ac7d */
            ii(0x1013_b241, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b244, 4); inc(memw[ds, eax + 0x4]);               /* inc word [eax+0x4] */
            ii(0x1013_b248, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b24a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b24b, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b24c, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b24d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b24e, 1); ret();                                  /* ret */
        }
    }
}
