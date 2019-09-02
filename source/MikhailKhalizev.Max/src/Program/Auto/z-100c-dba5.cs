using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_dba5-703e551c")]
        public void Method_100c_dba5()
        {
            ii(0x100c_dba5, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_dbaa, 5); call(Definitions.sys_check_available_stack_size, 0x9_81a3); /* call 0x10165d52 */
            ii(0x100c_dbaf, 1); push(ebx);                              /* push ebx */
            ii(0x100c_dbb0, 1); push(ecx);                              /* push ecx */
            ii(0x100c_dbb1, 1); push(esi);                              /* push esi */
            ii(0x100c_dbb2, 1); push(edi);                              /* push edi */
            ii(0x100c_dbb3, 1); push(ebp);                              /* push ebp */
            ii(0x100c_dbb4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_dbb6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_dbbc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_dbbf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_dbc2, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_dbc9, 2); jmp(0x100c_dbd1, 6); goto l_0x100c_dbd1; /* jmp 0x100cdbd1 */
        l_0x100c_dbcb:
            ii(0x100c_dbcb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_dbce, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x100c_dbd1:
            ii(0x100c_dbd1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_dbd4, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_dbd6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_dbd9, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100c_dbdd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_dbdf, 2); if(jge(0x100c_dc14, 0x33)) goto l_0x100c_dc14; /* jge 0x100cdc14 */
            ii(0x100c_dbe1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_dbe4, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_dbe7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_dbea, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_dbed, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100c_dbf1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_dbf4, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x100c_dbf6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_dbf9, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x100c_dbfc, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x100c_dbfe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_dc01, 5); call(/* sys */ 0x1016_61c4, 0x9_85be);  /* call 0x101661c4 */
            ii(0x100c_dc06, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_dc08, 2); if(jnz(0x100c_dc12, 8)) goto l_0x100c_dc12; /* jnz 0x100cdc12 */
            ii(0x100c_dc0a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_dc0d, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_dc10, 2); jmp(0x100c_dc1b, 9); goto l_0x100c_dc1b; /* jmp 0x100cdc1b */
        l_0x100c_dc12:
            ii(0x100c_dc12, 2); jmp(0x100c_dbcb, -0x49); goto l_0x100c_dbcb; /* jmp 0x100cdbcb */
        l_0x100c_dc14:
            ii(0x100c_dc14, 7); mov(memd[ss, ebp - 16], 0xffff_ffff);   /* mov dword [ebp-0x10], 0xffffffff */
        l_0x100c_dc1b:
            ii(0x100c_dc1b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_dc1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_dc20, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_dc21, 1); pop(edi);                               /* pop edi */
            ii(0x100c_dc22, 1); pop(esi);                               /* pop esi */
            ii(0x100c_dc23, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_dc24, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_dc25, 1); ret();                                  /* ret */
        }
    }
}
