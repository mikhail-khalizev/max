using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5c4b2cfb-171e-474b-ba48-9239f49706e4")]
        public void Method_1012_eb0d()
        {
            ii(0x1012_eb0d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_eb12, 5); calld(Definitions.sys_check_available_stack_size, 0x3723b); /* call 0x10165d52 */
            ii(0x1012_eb17, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_eb18, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_eb19, 1); pushd(esi);                             /* push esi */
            ii(0x1012_eb1a, 1); pushd(edi);                             /* push edi */
            ii(0x1012_eb1b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_eb1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_eb1e, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_eb24, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_eb27, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_eb2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_eb2d, 5); calld(0x1007_6338, -0xb87fa);           /* call 0x10076338 */
            ii(0x1012_eb32, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_eb34, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb37, 5); calld(0x1007_64b8, -0xb8684);           /* call 0x100764b8 */
            ii(0x1012_eb3c, 2); jmpd(0x1012_eb46, 0x8); goto l_0x1012_eb46; /* jmp 0x1012eb46 */
        l_0x1012_eb3e:
            ii(0x1012_eb3e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb41, 5); calld(0x1007_6bf8, -0xb7f4e);           /* call 0x10076bf8 */
        l_0x1012_eb46:
            ii(0x1012_eb46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_eb48, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb4b, 5); calld(0x1013_ad71, 0xc221);             /* call 0x1013ad71 */
            ii(0x1012_eb50, 2); test(al, al);                           /* test al, al */
            ii(0x1012_eb52, 6); if(jzd(0x1012_ec92, 0x13a)) goto l_0x1012_ec92; /* jz 0x1012ec92 */
            ii(0x1012_eb58, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb5b, 5); calld(0x1007_63a0, -0xb87c0);           /* call 0x100763a0 */
            ii(0x1012_eb60, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_eb62, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_eb65, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_eb67, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_eb6c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_eb6e, 2); if(jnzd(0x1012_eb87, 0x17)) goto l_0x1012_eb87; /* jnz 0x1012eb87 */
            ii(0x1012_eb70, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb73, 5); calld(0x1007_63a0, -0xb87d8);           /* call 0x100763a0 */
            ii(0x1012_eb78, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_eb7b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_eb7e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1012_eb81, 4); cmp(memb_a32[ds, eax + 0x40], 0);       /* cmp byte [eax+0x40], 0x0 */
            ii(0x1012_eb85, 2); if(jnzd(0x1012_eb89, 0x2)) goto l_0x1012_eb89; /* jnz 0x1012eb89 */
        l_0x1012_eb87:
            ii(0x1012_eb87, 2); jmpd(0x1012_ebac, 0x23); goto l_0x1012_ebac; /* jmp 0x1012ebac */
        l_0x1012_eb89:
            ii(0x1012_eb89, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb8c, 5); calld(0x1007_63a0, -0xb87f1);           /* call 0x100763a0 */
            ii(0x1012_eb91, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1012_eb95, 2); if(jnzd(0x1012_ebaa, 0x13)) goto l_0x1012_ebaa; /* jnz 0x1012ebaa */
            ii(0x1012_eb97, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_eb9a, 5); calld(0x1007_63a0, -0xb87ff);           /* call 0x100763a0 */
            ii(0x1012_eb9f, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_eba2, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_eba5, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x1012_eba8, 2); if(jzd(0x1012_ebac, 0x2)) goto l_0x1012_ebac; /* jz 0x1012ebac */
        l_0x1012_ebaa:
            ii(0x1012_ebaa, 2); jmpd(0x1012_ebae, 0x2); goto l_0x1012_ebae; /* jmp 0x1012ebae */
        l_0x1012_ebac:
            ii(0x1012_ebac, 2); jmpd(0x1012_ebdd, 0x2f); goto l_0x1012_ebdd; /* jmp 0x1012ebdd */
        l_0x1012_ebae:
            ii(0x1012_ebae, 7); cmp(memb_a32[ds, 0x101c_61b2], 0);      /* cmp byte [0x101c61b2], 0x0 */
            ii(0x1012_ebb5, 2); if(jzd(0x1012_ebdb, 0x24)) goto l_0x1012_ebdb; /* jz 0x1012ebdb */
            ii(0x1012_ebb7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ebba, 5); calld(0x1007_63a0, -0xb881f);           /* call 0x100763a0 */
            ii(0x1012_ebbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ebc1, 3); mov(dl, memb_a32[ds, eax + 0x4d]);      /* mov dl, [eax+0x4d] */
            ii(0x1012_ebc4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ebc7, 5); calld(0x1007_63a0, -0xb882c);           /* call 0x100763a0 */
            ii(0x1012_ebcc, 5); calld(0x1007_623c, -0xb8995);           /* call 0x1007623c */
            ii(0x1012_ebd1, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1012_ebd4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_ebd7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_ebd9, 2); if(jged(0x1012_ebdd, 0x2)) goto l_0x1012_ebdd; /* jge 0x1012ebdd */
        l_0x1012_ebdb:
            ii(0x1012_ebdb, 2); jmpd(0x1012_ebe2, 0x5); goto l_0x1012_ebe2; /* jmp 0x1012ebe2 */
        l_0x1012_ebdd:
            ii(0x1012_ebdd, 5); jmpd(0x1012_ec8d, 0xab); goto l_0x1012_ec8d; /* jmp 0x1012ec8d */
        l_0x1012_ebe2:
            ii(0x1012_ebe2, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1012_ebe9:
            ii(0x1012_ebe9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_ebec, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ebef, 5); calld(Definitions.my_1_get_count, -0x8371c); /* call 0x100ab4d8 */
            ii(0x1012_ebf4, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1012_ebf8, 6); if(jled(0x1012_ec74, 0x76)) goto l_0x1012_ec74; /* jle 0x1012ec74 */
            ii(0x1012_ebfe, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_ec02, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_ec05, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ec08, 5); calld(0x100e_8634, -0x465d9);           /* call 0x100e8634 */
            ii(0x1012_ec0d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ec0f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ec12, 5); calld(0x1007_63a0, -0xb8877);           /* call 0x100763a0 */
            ii(0x1012_ec17, 4); mov(dx, memw_a32[ds, edx + 0x8]);       /* mov dx, [edx+0x8] */
            ii(0x1012_ec1b, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1012_ec1f, 2); if(jgd(0x1012_ec74, 0x53)) goto l_0x1012_ec74; /* jg 0x1012ec74 */
            ii(0x1012_ec21, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_ec25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_ec28, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ec2b, 5); calld(0x100e_8634, -0x465fc);           /* call 0x100e8634 */
            ii(0x1012_ec30, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ec32, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ec35, 5); calld(0x1007_63a0, -0xb889a);           /* call 0x100763a0 */
            ii(0x1012_ec3a, 4); mov(dx, memw_a32[ds, edx + 0x8]);       /* mov dx, [edx+0x8] */
            ii(0x1012_ec3e, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1012_ec42, 2); if(jnzd(0x1012_ec65, 0x21)) goto l_0x1012_ec65; /* jnz 0x1012ec65 */
            ii(0x1012_ec44, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_ec48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_ec4b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ec4e, 5); calld(0x100e_8634, -0x4661f);           /* call 0x100e8634 */
            ii(0x1012_ec53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ec55, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ec58, 5); calld(0x1007_63a0, -0xb88bd);           /* call 0x100763a0 */
            ii(0x1012_ec5d, 3); mov(dl, memb_a32[ds, edx + 0x27]);      /* mov dl, [edx+0x27] */
            ii(0x1012_ec60, 3); cmp(dl, memb_a32[ds, eax + 0x27]);      /* cmp dl, [eax+0x27] */
            ii(0x1012_ec63, 2); if(jad(0x1012_ec67, 0x2)) goto l_0x1012_ec67; /* ja 0x1012ec67 */
        l_0x1012_ec65:
            ii(0x1012_ec65, 2); jmpd(0x1012_ec69, 0x2); goto l_0x1012_ec69; /* jmp 0x1012ec69 */
        l_0x1012_ec67:
            ii(0x1012_ec67, 2); jmpd(0x1012_ec74, 0xb); goto l_0x1012_ec74; /* jmp 0x1012ec74 */
        l_0x1012_ec69:
            ii(0x1012_ec69, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_ec6c, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1012_ec6f, 5); jmpd(0x1012_ebe9, -0x8b); goto l_0x1012_ebe9; /* jmp 0x1012ebe9 */
        l_0x1012_ec74:
            ii(0x1012_ec74, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1012_ec78, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ec7b, 5); calld(0x1007_63d4, -0xb88ac);           /* call 0x100763d4 */
            ii(0x1012_ec80, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ec82, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_ec85, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ec88, 5); calld(0x100e_85fc, -0x46691);           /* call 0x100e85fc */
        l_0x1012_ec8d:
            ii(0x1012_ec8d, 5); jmpd(0x1012_eb3e, -0x154); goto l_0x1012_eb3e; /* jmp 0x1012eb3e */
        l_0x1012_ec92:
            ii(0x1012_ec92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ec94, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_ec97, 5); calld(0x1007_5f6c, -0xb8d30);           /* call 0x10075f6c */
            ii(0x1012_ec9c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_ec9e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_ec9f, 1); popd(edi);                              /* pop edi */
            ii(0x1012_eca0, 1); popd(esi);                              /* pop esi */
            ii(0x1012_eca1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_eca2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_eca3, 1); retd(); return;                         /* ret */
        }
    }
}