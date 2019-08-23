using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_c32a-6954b430")]
        public void Method_1008_c32a()
        {
            ii(0x1008_c32a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_c32f, 5); call(Definitions.sys_check_available_stack_size, 0xd_9a1e); /* call 0x10165d52 */
            ii(0x1008_c334, 1); push(ebx);                              /* push ebx */
            ii(0x1008_c335, 1); push(ecx);                              /* push ecx */
            ii(0x1008_c336, 1); push(edx);                              /* push edx */
            ii(0x1008_c337, 1); push(esi);                              /* push esi */
            ii(0x1008_c338, 1); push(edi);                              /* push edi */
            ii(0x1008_c339, 1); push(ebp);                              /* push ebp */
            ii(0x1008_c33a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c33c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_c342, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_c345, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c347, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c34a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c34d, 5); call(0x1013_ad11, 0xa_e9bf);            /* call 0x1013ad11 */
            ii(0x1008_c352, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c354, 2); if(jz(0x1008_c37d, 0x27)) goto l_0x1008_c37d; /* jz 0x1008c37d */
            ii(0x1008_c356, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c359, 5); call(0x100a_71f8, 0x1_ae9a);            /* call 0x100a71f8 */
            ii(0x1008_c35e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c360, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c363, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_c366, 5); call(0x1008_afe4, -0x1387);             /* call 0x1008afe4 */
            ii(0x1008_c36b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_c36e, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_c373, 5); call(0x100a_5e27, 0x1_9aaf);            /* call 0x100a5e27 */
            ii(0x1008_c378, 5); jmp(0x1008_c405, 0x88); goto l_0x1008_c405; /* jmp 0x1008c405 */
        l_0x1008_c37d:
            ii(0x1008_c37d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c380, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c383, 5); call(0x1007_6574, -0x1_5e14);           /* call 0x10076574 */
            ii(0x1008_c388, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_c38b, 4); mov(dx, memw[ds, edx + 0x1f]);          /* mov dx, [edx+0x1f] */
            ii(0x1008_c38f, 4); cmp(dx, memw[ds, eax + 0x52]);          /* cmp dx, [eax+0x52] */
            ii(0x1008_c393, 2); if(jg(0x1008_c3b6, 0x21)) goto l_0x1008_c3b6; /* jg 0x1008c3b6 */
            ii(0x1008_c395, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c398, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_c39b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c39e, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_c3a1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c3a4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c3a7, 5); call(0x1007_65d0, -0x1_5ddc);           /* call 0x100765d0 */
            ii(0x1008_c3ac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c3ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c3b1, 3); call_abs(memd[ds, ebx + 0x58]);         /* call dword [ebx+0x58] */
            ii(0x1008_c3b4, 2); jmp(0x1008_c405, 0x4f); goto l_0x1008_c405; /* jmp 0x1008c405 */
        l_0x1008_c3b6:
            ii(0x1008_c3b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c3b8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c3bb, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c3be, 5); call(0x1013_ad71, 0xa_e9ae);            /* call 0x1013ad71 */
            ii(0x1008_c3c3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c3c5, 2); if(jz(0x1008_c3dc, 0x15)) goto l_0x1008_c3dc; /* jz 0x1008c3dc */
            ii(0x1008_c3c7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c3ca, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c3cd, 5); call(0x1007_6574, -0x1_5e5e);           /* call 0x10076574 */
            ii(0x1008_c3d2, 5); call(0x1015_26ac, 0xc_62d5);            /* call 0x101526ac */
            ii(0x1008_c3d7, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1008_c3da, 2); if(jz(0x1008_c3de, 0x2)) goto l_0x1008_c3de; /* jz 0x1008c3de */
        l_0x1008_c3dc:
            ii(0x1008_c3dc, 2); jmp(0x1008_c3f3, 0x15); goto l_0x1008_c3f3; /* jmp 0x1008c3f3 */
        l_0x1008_c3de:
            ii(0x1008_c3de, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c3e1, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c3e4, 5); call(0x1007_6574, -0x1_5e75);           /* call 0x10076574 */
            ii(0x1008_c3e9, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1008_c3ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c3ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c3f1, 2); if(jle(0x1008_c3f5, 0x2)) goto l_0x1008_c3f5; /* jle 0x1008c3f5 */
        l_0x1008_c3f3:
            ii(0x1008_c3f3, 2); jmp(0x1008_c3fd, 0x8); goto l_0x1008_c3fd; /* jmp 0x1008c3fd */
        l_0x1008_c3f5:
            ii(0x1008_c3f5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c3f8, 5); call(0x100a_71f8, 0x1_adfb);            /* call 0x100a71f8 */
        l_0x1008_c3fd:
            ii(0x1008_c3fd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c400, 5); call(0x100a_7017, 0x1_ac12);            /* call 0x100a7017 */
        l_0x1008_c405:
            ii(0x1008_c405, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c407, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_c408, 1); pop(edi);                               /* pop edi */
            ii(0x1008_c409, 1); pop(esi);                               /* pop esi */
            ii(0x1008_c40a, 1); pop(edx);                               /* pop edx */
            ii(0x1008_c40b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_c40c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_c40d, 1); ret();                                  /* ret */
        }
    }
}
