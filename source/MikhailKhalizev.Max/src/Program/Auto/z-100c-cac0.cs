using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_cac0-1c01ae20")]
        public void Method_100c_cac0()
        {
            ii(0x100c_cac0, 5); push(0x38);                             /* push 0x38 */
            ii(0x100c_cac5, 5); call(Definitions.sys_check_available_stack_size, 0x9_9288); /* call 0x10165d52 */
            ii(0x100c_caca, 1); push(ebx);                              /* push ebx */
            ii(0x100c_cacb, 1); push(ecx);                              /* push ecx */
            ii(0x100c_cacc, 1); push(edx);                              /* push edx */
            ii(0x100c_cacd, 1); push(esi);                              /* push esi */
            ii(0x100c_cace, 1); push(edi);                              /* push edi */
            ii(0x100c_cacf, 1); push(ebp);                              /* push ebp */
            ii(0x100c_cad0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_cad2, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_cad8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_cadb, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_cae0, 5); call(0x1007_6338, -0x5_67ad);           /* call 0x10076338 */
            ii(0x100c_cae5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_cae7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_caea, 5); call(0x1007_64b8, -0x5_6637);           /* call 0x100764b8 */
            ii(0x100c_caef, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100c_caf6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_caf9, 5); call(0x100c_bb8b, -0xf73);              /* call 0x100cbb8b */
            ii(0x100c_cafe, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_cb01, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100c_cb06, 2); if(jnz(0x100c_cb1e, 0x16)) goto l_0x100c_cb1e; /* jnz 0x100ccb1e */
            ii(0x100c_cb08, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_cb0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cb11, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb14, 5); call(0x1007_5f6c, -0x5_6bad);           /* call 0x10075f6c */
            ii(0x100c_cb19, 5); jmp(0x100c_cbc6, 0xa8); goto l_0x100c_cbc6; /* jmp 0x100ccbc6 */
        l_0x100c_cb1e:
            ii(0x100c_cb1e, 2); jmp(0x100c_cb28, 8); goto l_0x100c_cb28; /* jmp 0x100ccb28 */
        l_0x100c_cb20:
            ii(0x100c_cb20, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb23, 5); call(0x1007_6bf8, -0x5_5f30);           /* call 0x10076bf8 */
        l_0x100c_cb28:
            ii(0x100c_cb28, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cb2a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb2d, 5); call(0x1013_ad71, 0x6_e23f);            /* call 0x1013ad71 */
            ii(0x100c_cb32, 2); test(al, al);                           /* test al, al */
            ii(0x100c_cb34, 6); if(jz(0x100c_cbaa, 0x70)) goto l_0x100c_cbaa; /* jz 0x100ccbaa */
            ii(0x100c_cb3a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb3d, 5); call(0x1007_63a0, -0x5_67a2);           /* call 0x100763a0 */
            ii(0x100c_cb42, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cb44, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_cb47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cb4a, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100c_cb4d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_cb50, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_cb52, 2); if(jnz(0x100c_cb66, 0x12)) goto l_0x100c_cb66; /* jnz 0x100ccb66 */
            ii(0x100c_cb54, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb57, 5); call(0x1007_63a0, -0x5_67bc);           /* call 0x100763a0 */
            ii(0x100c_cb5c, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100c_cb60, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100c_cb64, 2); if(jz(0x100c_cb68, 2)) goto l_0x100c_cb68; /* jz 0x100ccb68 */
        l_0x100c_cb66:
            ii(0x100c_cb66, 2); jmp(0x100c_cba5, 0x3d); goto l_0x100c_cba5; /* jmp 0x100ccba5 */
        l_0x100c_cb68:
            ii(0x100c_cb68, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cb6b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_cb6e, 5); call(0x1008_abbc, -0x4_1fb7);           /* call 0x1008abbc */
            ii(0x100c_cb73, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_cb75, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb78, 5); call(0x1007_636c, -0x5_6811);           /* call 0x1007636c */
            ii(0x100c_cb7d, 5); call(0x100a_601a, -0x2_6b68);           /* call 0x100a601a */
            ii(0x100c_cb82, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_cb85, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100c_cb89, 2); if(jz(0x100c_cb94, 9)) goto l_0x100c_cb94; /* jz 0x100ccb94 */
            ii(0x100c_cb8b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_cb8e, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x100c_cb92, 2); if(jge(0x100c_cba5, 0x11)) goto l_0x100c_cba5; /* jge 0x100ccba5 */
        l_0x100c_cb94:
            ii(0x100c_cb94, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cb97, 5); call(0x1007_63d4, -0x5_67c8);           /* call 0x100763d4 */
            ii(0x100c_cb9c, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_cb9f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_cba2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100c_cba5:
            ii(0x100c_cba5, 5); jmp(0x100c_cb20, -0x8a); goto l_0x100c_cb20; /* jmp 0x100ccb20 */
        l_0x100c_cbaa:
            ii(0x100c_cbaa, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_cbad, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_cbb0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cbb2, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_cbb5, 5); call(0x1007_5f6c, -0x5_6c4e);           /* call 0x10075f6c */
            ii(0x100c_cbba, 2); jmp(0x100c_cbc6, 0xa); goto l_0x100c_cbc6; /* jmp 0x100ccbc6 */
        //  ii(0x100c_cbbc, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_cbbe, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
        //  ii(0x100c_cbc1, 5); call(0x1007_5f6c, -0x5_6c5a);           /* call 0x10075f6c */
        l_0x100c_cbc6:
            ii(0x100c_cbc6, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_cbc9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_cbcb, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_cbcc, 1); pop(edi);                               /* pop edi */
            ii(0x100c_cbcd, 1); pop(esi);                               /* pop esi */
            ii(0x100c_cbce, 1); pop(edx);                               /* pop edx */
            ii(0x100c_cbcf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_cbd0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_cbd1, 1); ret();                                  /* ret */
        }
    }
}
