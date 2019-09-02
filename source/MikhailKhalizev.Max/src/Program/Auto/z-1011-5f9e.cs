using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5f9e-c1f1fe37")]
        public void Method_1011_5f9e()
        {
            ii(0x1011_5f9e, 5); push(0x38);                             /* push 0x38 */
            ii(0x1011_5fa3, 5); call(Definitions.sys_check_available_stack_size, 0x4_fdaa); /* call 0x10165d52 */
            ii(0x1011_5fa8, 1); push(ebx);                              /* push ebx */
            ii(0x1011_5fa9, 1); push(ecx);                              /* push ecx */
            ii(0x1011_5faa, 1); push(edx);                              /* push edx */
            ii(0x1011_5fab, 1); push(esi);                              /* push esi */
            ii(0x1011_5fac, 1); push(edi);                              /* push edi */
            ii(0x1011_5fad, 1); push(ebp);                              /* push ebp */
            ii(0x1011_5fae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5fb0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_5fb6, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1011_5fbb, 5); call(0x100e_883d, -0x2_d783);           /* call 0x100e883d */
            ii(0x1011_5fc0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_5fc3, 6); mov(ax, memw[ds, 0x101c_52b4]);         /* mov ax, [0x101c52b4] */
            ii(0x1011_5fc9, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_5fcc, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_5fd3, 2); jmp(0x1011_5fe2, 0xd); goto l_0x1011_5fe2; /* jmp 0x10115fe2 */
        l_0x1011_5fd5:
            ii(0x1011_5fd5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_5fd8, 3); dec(memd[ss, ebp - 4]);                 /* dec dword [ebp-0x4] */
            ii(0x1011_5fdb, 7); add(memd[ss, ebp - 0xc], 0x280);        /* add dword [ebp-0xc], 0x280 */
        l_0x1011_5fe2:
            ii(0x1011_5fe2, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1011_5fe6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_5fe8, 2); if(jz(0x1011_603a, 0x50)) goto l_0x1011_603a; /* jz 0x1011603a */
            ii(0x1011_5fea, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1011_5ff1, 2); jmp(0x1011_5ff9, 6); goto l_0x1011_5ff9; /* jmp 0x10115ff9 */
        l_0x1011_5ff3:
            ii(0x1011_5ff3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_5ff6, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1011_5ff9:
            ii(0x1011_5ff9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_5ffc, 7); cmp(ax, memw[ds, 0x101c_52b2]);         /* cmp ax, [0x101c52b2] */
            ii(0x1011_6003, 2); if(jge(0x1011_6038, 0x33)) goto l_0x1011_6038; /* jge 0x10116038 */
            ii(0x1011_6005, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_6009, 3); add(edx, memd[ss, ebp - 0xc]);          /* add edx, [ebp-0xc] */
            ii(0x1011_600c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_600f, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_6012, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_6014, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1011_6016, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_601b, 6); mov(edx, memd[ds, 0x101c_52b8]);        /* mov edx, [0x101c52b8] */
            ii(0x1011_6021, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_6023, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_6027, 3); add(ebx, memd[ss, ebp - 0xc]);          /* add ebx, [ebp-0xc] */
            ii(0x1011_602a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_602d, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_6030, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_6032, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1011_6034, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1011_6036, 2); jmp(0x1011_5ff3, -0x45); goto l_0x1011_5ff3; /* jmp 0x10115ff3 */
        l_0x1011_6038:
            ii(0x1011_6038, 2); jmp(0x1011_5fd5, -0x65); goto l_0x1011_5fd5; /* jmp 0x10115fd5 */
        l_0x1011_603a:
            ii(0x1011_603a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_603c, 1); push(eax);                              /* push eax */
            ii(0x1011_603d, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1011_6042, 1); push(eax);                              /* push eax */
            ii(0x1011_6043, 5); mov(eax, 0x101c_4e64);                  /* mov eax, 0x101c4e64 */
            ii(0x1011_6048, 1); push(eax);                              /* push eax */
            ii(0x1011_6049, 5); mov(ecx, 0xa);                          /* mov ecx, 0xa */
            ii(0x1011_604e, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1011_6053, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x1011_6058, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_605b, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_605e, 5); call(0x1011_5aa9, -0x5ba);              /* call 0x10115aa9 */
            ii(0x1011_6063, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6065, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_6066, 1); pop(edi);                               /* pop edi */
            ii(0x1011_6067, 1); pop(esi);                               /* pop esi */
            ii(0x1011_6068, 1); pop(edx);                               /* pop edx */
            ii(0x1011_6069, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_606a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_606b, 1); ret();                                  /* ret */
        }
    }
}
