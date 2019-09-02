using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_9285-d25e8962")]
        public void Method_100b_9285()
        {
            ii(0x100b_9285, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_928a, 5); call(Definitions.sys_check_available_stack_size, 0xa_cac3); /* call 0x10165d52 */
            ii(0x100b_928f, 1); push(ebx);                              /* push ebx */
            ii(0x100b_9290, 1); push(ecx);                              /* push ecx */
            ii(0x100b_9291, 1); push(edx);                              /* push edx */
            ii(0x100b_9292, 1); push(esi);                              /* push esi */
            ii(0x100b_9293, 1); push(edi);                              /* push edi */
            ii(0x100b_9294, 1); push(ebp);                              /* push ebp */
            ii(0x100b_9295, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_9297, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_929d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_92a0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_92a3, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x100b_92a7, 2); if(jz(0x100b_92c1, 0x18)) goto l_0x100b_92c1; /* jz 0x100b92c1 */
            ii(0x100b_92a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_92ac, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100b_92b0, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100b_92b7, 2); if(jz(0x100b_92c1, 8)) goto l_0x100b_92c1; /* jz 0x100b92c1 */
            ii(0x100b_92b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_92bc, 5); call(0x100b_91b9, -0x108);              /* call 0x100b91b9 */
        l_0x100b_92c1:
            ii(0x100b_92c1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_92c4, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x100b_92c8, 6); if(jnz(0x100b_9371, 0xa3)) goto l_0x100b_9371; /* jnz 0x100b9371 */
            ii(0x100b_92ce, 7); mov(dx, memw[ds, 0x101c_8172]);         /* mov dx, [0x101c8172] */
            ii(0x100b_92d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_92d8, 4); mov(memw[ds, eax + 12], dx);            /* mov [eax+0xc], dx */
            ii(0x100b_92dc, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100b_92e1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_92e4, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_92e7, 5); call(Definitions.sys_new_arr, 0xa_cd24); /* call 0x10166010 */
            ii(0x100b_92ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_92ee, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_92f1, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
            ii(0x100b_92f4, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100b_92f9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_92fc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_92ff, 5); call(Definitions.sys_new_arr, 0xa_cd0c); /* call 0x10166010 */
            ii(0x100b_9304, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9306, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_9309, 3); mov(memd[ds, eax + 8], edx);            /* mov [eax+0x8], edx */
            ii(0x100b_930c, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_9313, 2); jmp(0x100b_931b, 6); goto l_0x100b_931b; /* jmp 0x100b931b */
        l_0x100b_9315:
            ii(0x100b_9315, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_9318, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100b_931b:
            ii(0x100b_931b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_931e, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100b_9325, 2); if(jge(0x100b_9371, 0x4a)) goto l_0x100b_9371; /* jge 0x100b9371 */
            ii(0x100b_9327, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100b_932c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_932f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100b_9331, 5); call(Definitions.sys_new_arr, 0xa_ccda); /* call 0x10166010 */
            ii(0x100b_9336, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9338, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_933c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_933f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_9341, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_9344, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100b_9347, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_9349, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100b_934b, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100b_9350, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_9353, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100b_9355, 5); call(Definitions.sys_new_arr, 0xa_ccb6); /* call 0x10166010 */
            ii(0x100b_935a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_935c, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_9360, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_9363, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_9365, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_9368, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100b_936b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_936d, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100b_936f, 2); jmp(0x100b_9315, -0x5c); goto l_0x100b_9315; /* jmp 0x100b9315 */
        l_0x100b_9371:
            ii(0x100b_9371, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_9378, 2); jmp(0x100b_9380, 6); goto l_0x100b_9380; /* jmp 0x100b9380 */
        l_0x100b_937a:
            ii(0x100b_937a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_937d, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100b_9380:
            ii(0x100b_9380, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_9383, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100b_938a, 2); if(jge(0x100b_93d8, 0x4c)) goto l_0x100b_93d8; /* jge 0x100b93d8 */
            ii(0x100b_938c, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x100b_9392, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_9395, 2); add(ebx, ebx);                          /* add ebx, ebx */
            ii(0x100b_9397, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9399, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_939d, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_93a0, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_93a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_93a5, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100b_93a8, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100b_93aa, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_93ac, 5); call(Definitions.sys_memset, 0xa_ca2f); /* call 0x10165de0 */
            ii(0x100b_93b1, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x100b_93b7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_93ba, 2); add(ebx, ebx);                          /* add ebx, ebx */
            ii(0x100b_93bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_93be, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_93c2, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_93c5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_93c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_93ca, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100b_93cd, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100b_93cf, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_93d1, 5); call(Definitions.sys_memset, 0xa_ca0a); /* call 0x10165de0 */
            ii(0x100b_93d6, 2); jmp(0x100b_937a, -0x5e); goto l_0x100b_937a; /* jmp 0x100b937a */
        l_0x100b_93d8:
            ii(0x100b_93d8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_93da, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_93db, 1); pop(edi);                               /* pop edi */
            ii(0x100b_93dc, 1); pop(esi);                               /* pop esi */
            ii(0x100b_93dd, 1); pop(edx);                               /* pop edx */
            ii(0x100b_93de, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_93df, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_93e0, 1); ret();                                  /* ret */
        }
    }
}
