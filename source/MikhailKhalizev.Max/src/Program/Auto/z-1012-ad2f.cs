using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_ad2f-8e322229")]
        public void Method_1012_ad2f()
        {
            ii(0x1012_ad2f, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_ad34, 5); call(Definitions.sys_check_available_stack_size, 0x3_b019); /* call 0x10165d52 */
            ii(0x1012_ad39, 1); push(ebx);                              /* push ebx */
            ii(0x1012_ad3a, 1); push(ecx);                              /* push ecx */
            ii(0x1012_ad3b, 1); push(edx);                              /* push edx */
            ii(0x1012_ad3c, 1); push(esi);                              /* push esi */
            ii(0x1012_ad3d, 1); push(edi);                              /* push edi */
            ii(0x1012_ad3e, 1); push(ebp);                              /* push ebp */
            ii(0x1012_ad3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_ad41, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_ad47, 5); call(/* sys */ 0x1016_5e9b, 0x3_b14f);  /* call 0x10165e9b */
            ii(0x1012_ad4c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_ad4f, 5); call(0x1012_72a5, -0x3aaf);             /* call 0x101272a5 */
            ii(0x1012_ad54, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1012_ad57, 7); mov(memb[ds, 0x101c_5630], 2);          /* mov byte [0x101c5630], 0x2 */
            ii(0x1012_ad5e, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_ad63, 4); mov(memb[ds, eax + 0xf], 0);            /* mov byte [eax+0xf], 0x0 */
            ii(0x1012_ad67, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1012_ad6c, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1012_ad70, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1012_ad75, 5); call(0x1012_70fb, -0x3c7f);             /* call 0x101270fb */
            ii(0x1012_ad7a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_ad7c, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_ad81, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1012_ad84, 6); if(jnz(0x1012_adf5, 0x6b)) goto l_0x1012_adf5; /* jnz 0x1012adf5 */
            ii(0x1012_ad8a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_ad8d, 6); mov(memw[ds, 0x101c_40d0], ax);         /* mov [0x101c40d0], ax */
        l_0x1012_ad93:
            ii(0x1012_ad93, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_ad98, 3); mov(al, memb[ds, eax + 0xf]);           /* mov al, [eax+0xf] */
            ii(0x1012_ad9b, 3); cmp(al, memb[ss, ebp - 4]);             /* cmp al, [ebp-0x4] */
            ii(0x1012_ad9e, 2); if(jz(0x1012_adb1, 0x11)) goto l_0x1012_adb1; /* jz 0x1012adb1 */
            ii(0x1012_ada0, 5); call(0x1012_75ed, -0x37b8);             /* call 0x101275ed */
            ii(0x1012_ada5, 5); call(/* sys */ 0x1016_b208, 0x4_045e);  /* call 0x1016b208 */
            ii(0x1012_adaa, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_adad, 2); if(jz(0x1012_adfe, 0x4f)) goto l_0x1012_adfe; /* jz 0x1012adfe */
            ii(0x1012_adaf, 2); jmp(0x1012_ad93, -0x1e); goto l_0x1012_ad93; /* jmp 0x1012ad93 */
        l_0x1012_adb1:
            ii(0x1012_adb1, 5); call(0x1012_accb, -0xeb);               /* call 0x1012accb */
            ii(0x1012_adb6, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1012_adba, 2); jmp(0x1012_adc2, 6); goto l_0x1012_adc2; /* jmp 0x1012adc2 */
        l_0x1012_adbc:
            ii(0x1012_adbc, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_adbf, 3); inc(memb[ss, ebp - 0xc]);               /* inc byte [ebp-0xc] */
        l_0x1012_adc2:
            ii(0x1012_adc2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_adc4, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_adc7, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1012_adca, 2); if(jge(0x1012_adf5, 0x29)) goto l_0x1012_adf5; /* jge 0x1012adf5 */
            ii(0x1012_adcc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_adce, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_add1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_add7, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_addd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_ade2, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1012_ade5, 2); if(jnz(0x1012_adf3, 0xc)) goto l_0x1012_adf3; /* jnz 0x1012adf3 */
            ii(0x1012_ade7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_ade9, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_adec, 7); mov(memb[ds, eax + 0x101c_40b0], 1);    /* mov byte [eax+0x101c40b0], 0x1 */
        l_0x1012_adf3:
            ii(0x1012_adf3, 2); jmp(0x1012_adbc, -0x39); goto l_0x1012_adbc; /* jmp 0x1012adbc */
        l_0x1012_adf5:
            ii(0x1012_adf5, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_adfa, 4); mov(memb[ds, eax + 0xa], 1);            /* mov byte [eax+0xa], 0x1 */
        l_0x1012_adfe:
            ii(0x1012_adfe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_ae00, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_ae01, 1); pop(edi);                               /* pop edi */
            ii(0x1012_ae02, 1); pop(esi);                               /* pop esi */
            ii(0x1012_ae03, 1); pop(edx);                               /* pop edx */
            ii(0x1012_ae04, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_ae05, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_ae06, 1); ret();                                  /* ret */
        }
    }
}
