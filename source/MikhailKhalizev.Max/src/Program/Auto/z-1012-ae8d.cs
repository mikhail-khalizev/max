using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("276f4663-19f9-4bd3-af35-3049a225f7d3")]
        public void Method_1012_ae8d()
        {
            ii(0x1012_ae8d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_ae92, 5); calld(Definitions.sys_check_available_stack_size, 0x3_aebb); /* call 0x10165d52 */
            ii(0x1012_ae97, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_ae98, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_ae99, 1); pushd(edx);                             /* push edx */
            ii(0x1012_ae9a, 1); pushd(esi);                             /* push esi */
            ii(0x1012_ae9b, 1); pushd(edi);                             /* push edi */
            ii(0x1012_ae9c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_ae9d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_ae9f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_aea5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_aea8, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x26);   /* mov byte [0x101c5c1c], 0x26 */
            ii(0x1012_aeaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_aeb2, 5); calld(0x1007_6154, -0xb_4d63);          /* call 0x10076154 */
            ii(0x1012_aeb7, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_aebd, 7); mov(memd_a32[ss, ebp - 0x8], 0x101c_5c21); /* mov dword [ebp-0x8], 0x101c5c21 */
            ii(0x1012_aec4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_aec7, 3); mov(dl, memb_a32[ds, eax + 0x3d]);      /* mov dl, [eax+0x3d] */
            ii(0x1012_aeca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_aecd, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1012_aecf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_aed2, 3); mov(dl, memb_a32[ds, eax + 0x3e]);      /* mov dl, [eax+0x3e] */
            ii(0x1012_aed5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_aed8, 3); mov(memb_a32[ds, eax + 0x1], dl);       /* mov [eax+0x1], dl */
            ii(0x1012_aedb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_aede, 4); mov(dx, memw_a32[ds, eax + 0x41]);      /* mov dx, [eax+0x41] */
            ii(0x1012_aee2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_aee5, 4); mov(memw_a32[ds, eax + 0x2], dx);       /* mov [eax+0x2], dx */
            ii(0x1012_aee9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_aeec, 4); mov(dx, memw_a32[ds, eax + 0x43]);      /* mov dx, [eax+0x43] */
            ii(0x1012_aef0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_aef3, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1012_aef7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_aefa, 3); mov(dl, memb_a32[ds, eax + 0x4f]);      /* mov dl, [eax+0x4f] */
            ii(0x1012_aefd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_af00, 3); mov(memb_a32[ds, eax + 0x14], dl);      /* mov [eax+0x14], dl */
            ii(0x1012_af03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_af05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af08, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_af0b, 5); calld(0x1013_ad71, 0xfe61);             /* call 0x1013ad71 */
            ii(0x1012_af10, 2); test(al, al);                           /* test al, al */
            ii(0x1012_af12, 6); if(jzd(0x1012_aff0, 0xd8)) goto l_0x1012_aff0; /* jz 0x1012aff0 */
            ii(0x1012_af18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af1b, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1012_af1f, 6); if(jzd(0x1012_afc5, 0xa0)) goto l_0x1012_afc5; /* jz 0x1012afc5 */
            ii(0x1012_af25, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af28, 3); mov(dl, memb_a32[ds, eax + 0x4e]);      /* mov dl, [eax+0x4e] */
            ii(0x1012_af2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_af2e, 3); mov(memb_a32[ds, eax + 0x15], dl);      /* mov [eax+0x15], dl */
            ii(0x1012_af31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af34, 3); mov(dl, memb_a32[ds, eax + 0x64]);      /* mov dl, [eax+0x64] */
            ii(0x1012_af37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_af3a, 3); mov(memb_a32[ds, eax + 0x16], dl);      /* mov [eax+0x16], dl */
            ii(0x1012_af3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af40, 3); mov(al, memb_a32[ds, eax + 0x2a]);      /* mov al, [eax+0x2a] */
            ii(0x1012_af43, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_af46, 3); mov(memb_a32[ds, edx + 0x17], al);      /* mov [edx+0x17], al */
            ii(0x1012_af49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af4c, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_af4f, 5); calld(0x1007_69d8, -0xb_457c);          /* call 0x100769d8 */
            ii(0x1012_af54, 5); calld(0x1012_0c30, -0xa329);            /* call 0x10120c30 */
            ii(0x1012_af59, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_af5c, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x1012_af60, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af63, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_af66, 5); calld(0x1007_69d8, -0xb_4593);          /* call 0x100769d8 */
            ii(0x1012_af6b, 5); calld(0x1012_0bfc, -0xa374);            /* call 0x10120bfc */
            ii(0x1012_af70, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_af73, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1012_af77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af7a, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_af7d, 5); calld(0x1007_69d8, -0xb_45aa);          /* call 0x100769d8 */
            ii(0x1012_af82, 5); calld(0x1012_b5cc, 0x645);              /* call 0x1012b5cc */
            ii(0x1012_af87, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_af8a, 3); mov(memd_a32[ds, edx + 0xa], eax);      /* mov [edx+0xa], eax */
            ii(0x1012_af8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_af90, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_af93, 5); calld(0x1007_69d8, -0xb_45c0);          /* call 0x100769d8 */
            ii(0x1012_af98, 5); calld(0x1012_b59c, 0x5ff);              /* call 0x1012b59c */
            ii(0x1012_af9d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_afa0, 3); mov(memd_a32[ds, edx + 0xe], eax);      /* mov [edx+0xe], eax */
            ii(0x1012_afa3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_afa6, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_afa9, 5); calld(0x1007_69d8, -0xb_45d6);          /* call 0x100769d8 */
            ii(0x1012_afae, 5); calld(0x1012_b568, 0x5b5);              /* call 0x1012b568 */
            ii(0x1012_afb3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_afb6, 4); mov(memw_a32[ds, edx + 0x12], ax);      /* mov [edx+0x12], ax */
            ii(0x1012_afba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_afbd, 6); mov(memw_a32[ds, eax + 0x18], 0x1);     /* mov word [eax+0x18], 0x1 */
            ii(0x1012_afc3, 2); jmpd(0x1012_afee, 0x29); goto l_0x1012_afee; /* jmp 0x1012afee */
        l_0x1012_afc5:
            ii(0x1012_afc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_afc8, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_afcb, 5); calld(0x1007_69d8, -0xb_45f8);          /* call 0x100769d8 */
            ii(0x1012_afd0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_afd3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_afd6, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1012_afd9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_afdc, 3); add(edx, 0x1a);                         /* add edx, 0x1a */
            ii(0x1012_afdf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_afe2, 3); calld_abs(memd_a32[ds, ebx + 0x3c]);    /* call dword [ebx+0x3c] */
            ii(0x1012_afe5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_afe7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_afea, 4); mov(memw_a32[ds, eax + 0x18], dx);      /* mov [eax+0x18], dx */
        l_0x1012_afee:
            ii(0x1012_afee, 2); jmpd(0x1012_aff9, 0x9); goto l_0x1012_aff9; /* jmp 0x1012aff9 */
        l_0x1012_aff0:
            ii(0x1012_aff0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_aff3, 6); mov(memw_a32[ds, eax + 0x18], 0);       /* mov word [eax+0x18], 0x0 */
        l_0x1012_aff9:
            ii(0x1012_aff9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_affc, 4); mov(ax, memw_a32[ds, eax + 0x18]);      /* mov ax, [eax+0x18] */
            ii(0x1012_b000, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_b002, 5); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x1012_b007, 6); mov(memw_a32[ds, 0x101c_5c1f], ax);     /* mov [0x101c5c1f], ax */
            ii(0x1012_b00d, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_b012, 5); calld(0x1012_5be9, -0x542e);            /* call 0x10125be9 */
            ii(0x1012_b017, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b019, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b01a, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b01b, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b01c, 1); popd(edx);                              /* pop edx */
            ii(0x1012_b01d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b01e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b01f, 1); retd(); return;                         /* ret */
        }
    }
}
