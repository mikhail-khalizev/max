using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_80fc-e4d5de2e")]
        public void /* sys */ Method_1017_80fc()
        {
            ii(0x1017_80fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_80fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_80fe, 1); pushd(edx);                             /* push edx */
            ii(0x1017_80ff, 1); pushd(esi);                             /* push esi */
            ii(0x1017_8100, 1); pushd(edi);                             /* push edi */
            ii(0x1017_8101, 6); mov(edx, memd_a32[ds, 0x1020_9540]);    /* mov edx, [0x10209540] */
            ii(0x1017_8107, 5); calld(/* sys */ 0x1017_49cc, -0x3740);  /* call 0x101749cc */
            ii(0x1017_810c, 5); mov(ebx, 0x5c);                         /* mov ebx, 0x5c */
            ii(0x1017_8111, 5); mov(ecx, 0x7c);                         /* mov ecx, 0x7c */
            ii(0x1017_8116, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_811b, 5); mov(edi, 0x5b);                         /* mov edi, 0x5b */
            ii(0x1017_8120, 7); mov(memw_a32[ds, 0x1020_8bda], bx);     /* mov [0x10208bda], bx */
            ii(0x1017_8127, 7); mov(memw_a32[ds, 0x1020_8bdc], cx);     /* mov [0x10208bdc], cx */
            ii(0x1017_812e, 7); mov(memw_a32[ds, 0x1020_8bde], si);     /* mov [0x10208bde], si */
            ii(0x1017_8135, 7); mov(memw_a32[ds, 0x1020_8be0], si);     /* mov [0x10208be0], si */
            ii(0x1017_813c, 7); mov(memw_a32[ds, 0x1020_8be2], si);     /* mov [0x10208be2], si */
            ii(0x1017_8143, 7); mov(memw_a32[ds, 0x1020_8da0], si);     /* mov [0x10208da0], si */
            ii(0x1017_814a, 7); mov(memw_a32[ds, 0x1020_8da2], si);     /* mov [0x10208da2], si */
            ii(0x1017_8151, 7); mov(memw_a32[ds, 0x1020_8da4], si);     /* mov [0x10208da4], si */
            ii(0x1017_8158, 7); mov(memw_a32[ds, 0x1020_8a58], si);     /* mov [0x10208a58], si */
            ii(0x1017_815f, 7); mov(memw_a32[ds, 0x1020_8a5a], si);     /* mov [0x10208a5a], si */
            ii(0x1017_8166, 7); mov(memw_a32[ds, 0x1020_8a5c], si);     /* mov [0x10208a5c], si */
            ii(0x1017_816d, 7); mov(memw_a32[ds, 0x1020_8a62], si);     /* mov [0x10208a62], si */
            ii(0x1017_8174, 7); mov(memw_a32[ds, 0x1020_8a64], si);     /* mov [0x10208a64], si */
            ii(0x1017_817b, 7); mov(memw_a32[ds, 0x1020_8a66], si);     /* mov [0x10208a66], si */
            ii(0x1017_8182, 7); mov(memw_a32[ds, 0x1020_8a6c], si);     /* mov [0x10208a6c], si */
            ii(0x1017_8189, 7); mov(memw_a32[ds, 0x1020_8a6e], si);     /* mov [0x10208a6e], si */
            ii(0x1017_8190, 7); mov(memw_a32[ds, 0x1020_8a70], si);     /* mov [0x10208a70], si */
            ii(0x1017_8197, 7); mov(memw_a32[ds, 0x1020_8a8a], si);     /* mov [0x10208a8a], si */
            ii(0x1017_819e, 7); mov(memw_a32[ds, 0x1020_8a8c], si);     /* mov [0x10208a8c], si */
            ii(0x1017_81a5, 7); mov(memw_a32[ds, 0x1020_8a8e], si);     /* mov [0x10208a8e], si */
            ii(0x1017_81ac, 7); mov(memw_a32[ds, 0x1020_8a94], si);     /* mov [0x10208a94], si */
            ii(0x1017_81b3, 7); mov(memw_a32[ds, 0x1020_8a96], si);     /* mov [0x10208a96], si */
            ii(0x1017_81ba, 7); mov(memw_a32[ds, 0x1020_8a98], si);     /* mov [0x10208a98], si */
            ii(0x1017_81c1, 7); mov(memw_a32[ds, 0x1020_8a9e], si);     /* mov [0x10208a9e], si */
            ii(0x1017_81c8, 7); mov(memw_a32[ds, 0x1020_8aa0], si);     /* mov [0x10208aa0], si */
            ii(0x1017_81cf, 7); mov(memw_a32[ds, 0x1020_8aa2], si);     /* mov [0x10208aa2], si */
            ii(0x1017_81d6, 7); mov(memw_a32[ds, 0x1020_8aa8], si);     /* mov [0x10208aa8], si */
            ii(0x1017_81dd, 7); mov(memw_a32[ds, 0x1020_8aaa], si);     /* mov [0x10208aaa], si */
            ii(0x1017_81e4, 7); mov(memw_a32[ds, 0x1020_8aac], si);     /* mov [0x10208aac], si */
            ii(0x1017_81eb, 7); mov(memw_a32[ds, 0x1020_8ab2], si);     /* mov [0x10208ab2], si */
            ii(0x1017_81f2, 7); mov(memw_a32[ds, 0x1020_8ab4], si);     /* mov [0x10208ab4], si */
            ii(0x1017_81f9, 7); mov(memw_a32[ds, 0x1020_8ab6], si);     /* mov [0x10208ab6], si */
            ii(0x1017_8200, 7); mov(memw_a32[ds, 0x1020_8abc], si);     /* mov [0x10208abc], si */
            ii(0x1017_8207, 7); mov(memw_a32[ds, 0x1020_8abe], si);     /* mov [0x10208abe], si */
            ii(0x1017_820e, 7); mov(memw_a32[ds, 0x1020_8ac0], si);     /* mov [0x10208ac0], si */
            ii(0x1017_8215, 7); mov(memw_a32[ds, 0x1020_8ac6], si);     /* mov [0x10208ac6], si */
            ii(0x1017_821c, 7); mov(memw_a32[ds, 0x1020_8ac8], si);     /* mov [0x10208ac8], si */
            ii(0x1017_8223, 7); mov(memw_a32[ds, 0x1020_8aca], si);     /* mov [0x10208aca], si */
            ii(0x1017_822a, 7); mov(memw_a32[ds, 0x1020_8b48], si);     /* mov [0x10208b48], si */
            ii(0x1017_8231, 7); mov(memw_a32[ds, 0x1020_8b4a], di);     /* mov [0x10208b4a], di */
            ii(0x1017_8238, 7); mov(memw_a32[ds, 0x1020_8b4c], si);     /* mov [0x10208b4c], si */
            ii(0x1017_823f, 7); mov(memw_a32[ds, 0x1020_8b52], si);     /* mov [0x10208b52], si */
            ii(0x1017_8246, 7); mov(memw_a32[ds, 0x1020_8b56], si);     /* mov [0x10208b56], si */
            ii(0x1017_824d, 7); mov(memw_a32[ds, 0x1020_8bca], si);     /* mov [0x10208bca], si */
            ii(0x1017_8254, 7); mov(memw_a32[ds, 0x1020_8bce], si);     /* mov [0x10208bce], si */
            ii(0x1017_825b, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1017_8260, 5); mov(ecx, 0x3e);                         /* mov ecx, 0x3e */
            ii(0x1017_8265, 5); mov(edi, 0x5d);                         /* mov edi, 0x5d */
            ii(0x1017_826a, 7); mov(memw_a32[ds, 0x1020_8d9c], bx);     /* mov [0x10208d9c], bx */
            ii(0x1017_8271, 7); mov(memw_a32[ds, 0x1020_8d9e], cx);     /* mov [0x10208d9e], cx */
            ii(0x1017_8278, 7); mov(memw_a32[ds, 0x1020_8b54], di);     /* mov [0x10208b54], di */
            ii(0x1017_827f, 5); mov(ebx, 0x31);                         /* mov ebx, 0x31 */
            ii(0x1017_8284, 5); mov(ecx, 0x21);                         /* mov ecx, 0x21 */
            ii(0x1017_8289, 5); mov(edi, 0x40);                         /* mov edi, 0x40 */
            ii(0x1017_828e, 7); mov(memw_a32[ds, 0x1020_8a54], bx);     /* mov [0x10208a54], bx */
            ii(0x1017_8295, 7); mov(memw_a32[ds, 0x1020_8a56], cx);     /* mov [0x10208a56], cx */
            ii(0x1017_829c, 7); mov(memw_a32[ds, 0x1020_8bcc], di);     /* mov [0x10208bcc], di */
            ii(0x1017_82a3, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1017_82a8, 5); mov(ecx, 0x22);                         /* mov ecx, 0x22 */
            ii(0x1017_82ad, 7); mov(memw_a32[ds, 0x1020_8a5e], bx);     /* mov [0x10208a5e], bx */
            ii(0x1017_82b4, 7); mov(memw_a32[ds, 0x1020_8a60], cx);     /* mov [0x10208a60], cx */
            ii(0x1017_82bb, 5); mov(ebx, 0x33);                         /* mov ebx, 0x33 */
            ii(0x1017_82c0, 5); mov(ecx, 0xa3);                         /* mov ecx, 0xa3 */
            ii(0x1017_82c5, 7); mov(memw_a32[ds, 0x1020_8a68], bx);     /* mov [0x10208a68], bx */
            ii(0x1017_82cc, 7); mov(memw_a32[ds, 0x1020_8a6a], cx);     /* mov [0x10208a6a], cx */
            ii(0x1017_82d3, 5); mov(ebx, 0x36);                         /* mov ebx, 0x36 */
            ii(0x1017_82d8, 5); mov(ecx, 0x26);                         /* mov ecx, 0x26 */
            ii(0x1017_82dd, 7); mov(memw_a32[ds, 0x1020_8a86], bx);     /* mov [0x10208a86], bx */
            ii(0x1017_82e4, 7); mov(memw_a32[ds, 0x1020_8a88], cx);     /* mov [0x10208a88], cx */
            ii(0x1017_82eb, 5); mov(ebx, 0x37);                         /* mov ebx, 0x37 */
            ii(0x1017_82f0, 5); mov(ecx, 0x2f);                         /* mov ecx, 0x2f */
            ii(0x1017_82f5, 7); mov(memw_a32[ds, 0x1020_8a90], bx);     /* mov [0x10208a90], bx */
            ii(0x1017_82fc, 7); mov(memw_a32[ds, 0x1020_8a92], cx);     /* mov [0x10208a92], cx */
            ii(0x1017_8303, 5); mov(ebx, 0x38);                         /* mov ebx, 0x38 */
            ii(0x1017_8308, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x1017_830d, 7); mov(memw_a32[ds, 0x1020_8a9a], bx);     /* mov [0x10208a9a], bx */
            ii(0x1017_8314, 7); mov(memw_a32[ds, 0x1020_8a9c], cx);     /* mov [0x10208a9c], cx */
            ii(0x1017_831b, 5); mov(ebx, 0x39);                         /* mov ebx, 0x39 */
            ii(0x1017_8320, 5); mov(ecx, 0x29);                         /* mov ecx, 0x29 */
            ii(0x1017_8325, 7); mov(memw_a32[ds, 0x1020_8aa4], bx);     /* mov [0x10208aa4], bx */
            ii(0x1017_832c, 7); mov(memw_a32[ds, 0x1020_8aa6], cx);     /* mov [0x10208aa6], cx */
            ii(0x1017_8333, 5); mov(ebx, 0x30);                         /* mov ebx, 0x30 */
            ii(0x1017_8338, 5); mov(ecx, 0x3d);                         /* mov ecx, 0x3d */
            ii(0x1017_833d, 7); mov(memw_a32[ds, 0x1020_8aae], bx);     /* mov [0x10208aae], bx */
            ii(0x1017_8344, 7); mov(memw_a32[ds, 0x1020_8ab0], cx);     /* mov [0x10208ab0], cx */
            ii(0x1017_834b, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1017_8350, 5); mov(ecx, 0x3f);                         /* mov ecx, 0x3f */
            ii(0x1017_8355, 7); mov(memw_a32[ds, 0x1020_8ab8], bx);     /* mov [0x10208ab8], bx */
            ii(0x1017_835c, 7); mov(memw_a32[ds, 0x1020_8aba], cx);     /* mov [0x10208aba], cx */
            ii(0x1017_8363, 5); mov(ebx, 0xec);                         /* mov ebx, 0xec */
            ii(0x1017_8368, 5); mov(ecx, 0x5e);                         /* mov ecx, 0x5e */
            ii(0x1017_836d, 7); mov(memw_a32[ds, 0x1020_8ac2], bx);     /* mov [0x10208ac2], bx */
            ii(0x1017_8374, 7); mov(memw_a32[ds, 0x1020_8ac4], cx);     /* mov [0x10208ac4], cx */
            ii(0x1017_837b, 5); mov(ebx, 0xe8);                         /* mov ebx, 0xe8 */
            ii(0x1017_8380, 5); mov(ecx, 0xe9);                         /* mov ecx, 0xe9 */
            ii(0x1017_8385, 7); mov(memw_a32[ds, 0x1020_8b44], bx);     /* mov [0x10208b44], bx */
            ii(0x1017_838c, 7); mov(memw_a32[ds, 0x1020_8b46], cx);     /* mov [0x10208b46], cx */
            ii(0x1017_8393, 5); mov(ebx, 0x2b);                         /* mov ebx, 0x2b */
            ii(0x1017_8398, 5); mov(ecx, 0x2a);                         /* mov ecx, 0x2a */
            ii(0x1017_839d, 7); mov(memw_a32[ds, 0x1020_8b4e], bx);     /* mov [0x10208b4e], bx */
            ii(0x1017_83a4, 7); mov(memw_a32[ds, 0x1020_8b50], cx);     /* mov [0x10208b50], cx */
            ii(0x1017_83ab, 5); mov(ebx, 0xf2);                         /* mov ebx, 0xf2 */
            ii(0x1017_83b0, 5); mov(ecx, 0xe7);                         /* mov ecx, 0xe7 */
            ii(0x1017_83b5, 7); mov(memw_a32[ds, 0x1020_8bc6], bx);     /* mov [0x10208bc6], bx */
            ii(0x1017_83bc, 7); mov(memw_a32[ds, 0x1020_8bc8], cx);     /* mov [0x10208bc8], cx */
            ii(0x1017_83c3, 5); mov(edx, 0xe0);                         /* mov edx, 0xe0 */
            ii(0x1017_83c8, 5); mov(ebx, 0xb0);                         /* mov ebx, 0xb0 */
            ii(0x1017_83cd, 5); mov(eax, 0xf9);                         /* mov eax, 0xf9 */
            ii(0x1017_83d2, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1017_83d4, 7); mov(memw_a32[ds, 0x1020_8bd4], si);     /* mov [0x10208bd4], si */
            ii(0x1017_83db, 5); mov(esi, 0x23);                         /* mov esi, 0x23 */
            ii(0x1017_83e0, 7); mov(memw_a32[ds, 0x1020_8bd0], dx);     /* mov [0x10208bd0], dx */
            ii(0x1017_83e7, 7); mov(memw_a32[ds, 0x1020_8bd2], bx);     /* mov [0x10208bd2], bx */
            ii(0x1017_83ee, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1017_83f0, 6); mov(memw_a32[ds, 0x1020_8bee], ax);     /* mov [0x10208bee], ax */
            ii(0x1017_83f6, 7); mov(memw_a32[ds, 0x1020_8bf2], cx);     /* mov [0x10208bf2], cx */
            ii(0x1017_83fd, 7); mov(memw_a32[ds, 0x1020_8bf4], cx);     /* mov [0x10208bf4], cx */
            ii(0x1017_8404, 7); mov(memw_a32[ds, 0x1020_8bf6], cx);     /* mov [0x10208bf6], cx */
            ii(0x1017_840b, 5); mov(edx, 0xa7);                         /* mov edx, 0xa7 */
            ii(0x1017_8410, 7); mov(memw_a32[ds, 0x1020_8bd6], si);     /* mov [0x10208bd6], si */
            ii(0x1017_8417, 7); mov(memw_a32[ds, 0x1020_8bf0], dx);     /* mov [0x10208bf0], dx */
            ii(0x1017_841e, 6); mov(edx, memd_a32[ds, 0x1020_9540]);    /* mov edx, [0x10209540] */
            ii(0x1017_8424, 7); mov(memw_a32[ds, 0x1020_8bd8], di);     /* mov [0x10208bd8], di */
            ii(0x1017_842b, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_842d, 2); if(jzd(0x1017_8443, 0x14)) goto l_0x1017_8443; /* jz 0x10178443 */
            ii(0x1017_842f, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8432, 2); if(jnzd(0x1017_843b, 0x7)) goto l_0x1017_843b; /* jnz 0x1017843b */
            ii(0x1017_8434, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_8439, 2); jmpd(0x1017_8448, 0xd); goto l_0x1017_8448; /* jmp 0x10178448 */
        l_0x1017_843b:
            ii(0x1017_843b, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_843e, 2); if(jzd(0x1017_8443, 0x3)) goto l_0x1017_8443; /* jz 0x10178443 */
            ii(0x1017_8440, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8443:
            ii(0x1017_8443, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_8448:
            ii(0x1017_8448, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_844a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_844d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_844f, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x2c); /* mov word [eax*2+0x10208a40], 0x2c */
            ii(0x1017_8459, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_845b, 2); if(jzd(0x1017_8471, 0x14)) goto l_0x1017_8471; /* jz 0x10178471 */
            ii(0x1017_845d, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8460, 2); if(jnzd(0x1017_8469, 0x7)) goto l_0x1017_8469; /* jnz 0x10178469 */
            ii(0x1017_8462, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_8467, 2); jmpd(0x1017_8476, 0xd); goto l_0x1017_8476; /* jmp 0x10178476 */
        l_0x1017_8469:
            ii(0x1017_8469, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_846c, 2); if(jzd(0x1017_8471, 0x3)) goto l_0x1017_8471; /* jz 0x10178471 */
            ii(0x1017_846e, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8471:
            ii(0x1017_8471, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_8476:
            ii(0x1017_8476, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_8478, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_847b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_847d, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x3b); /* mov word [eax*2+0x10208a42], 0x3b */
            ii(0x1017_8487, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_8489, 2); if(jzd(0x1017_849f, 0x14)) goto l_0x1017_849f; /* jz 0x1017849f */
            ii(0x1017_848b, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_848e, 2); if(jnzd(0x1017_8497, 0x7)) goto l_0x1017_8497; /* jnz 0x10178497 */
            ii(0x1017_8490, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_8495, 2); jmpd(0x1017_84a4, 0xd); goto l_0x1017_84a4; /* jmp 0x101784a4 */
        l_0x1017_8497:
            ii(0x1017_8497, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_849a, 2); if(jzd(0x1017_849f, 0x3)) goto l_0x1017_849f; /* jz 0x1017849f */
            ii(0x1017_849c, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_849f:
            ii(0x1017_849f, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_84a4:
            ii(0x1017_84a4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_84a6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_84a9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_84ab, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_84b5, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_84b7, 2); if(jzd(0x1017_84cd, 0x14)) goto l_0x1017_84cd; /* jz 0x101784cd */
            ii(0x1017_84b9, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_84bc, 2); if(jnzd(0x1017_84c5, 0x7)) goto l_0x1017_84c5; /* jnz 0x101784c5 */
            ii(0x1017_84be, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_84c3, 2); jmpd(0x1017_84d2, 0xd); goto l_0x1017_84d2; /* jmp 0x101784d2 */
        l_0x1017_84c5:
            ii(0x1017_84c5, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_84c8, 2); if(jzd(0x1017_84cd, 0x3)) goto l_0x1017_84cd; /* jz 0x101784cd */
            ii(0x1017_84ca, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_84cd:
            ii(0x1017_84cd, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_84d2:
            ii(0x1017_84d2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_84d4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_84d7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_84d9, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_84e3, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_84e5, 2); if(jzd(0x1017_84fb, 0x14)) goto l_0x1017_84fb; /* jz 0x101784fb */
            ii(0x1017_84e7, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_84ea, 2); if(jnzd(0x1017_84f3, 0x7)) goto l_0x1017_84f3; /* jnz 0x101784f3 */
            ii(0x1017_84ec, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_84f1, 2); jmpd(0x1017_8500, 0xd); goto l_0x1017_8500; /* jmp 0x10178500 */
        l_0x1017_84f3:
            ii(0x1017_84f3, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_84f6, 2); if(jzd(0x1017_84fb, 0x3)) goto l_0x1017_84fb; /* jz 0x101784fb */
            ii(0x1017_84f8, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_84fb:
            ii(0x1017_84fb, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_8500:
            ii(0x1017_8500, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_8502, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_8505, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_8507, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_8511, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_8513, 2); if(jzd(0x1017_8529, 0x14)) goto l_0x1017_8529; /* jz 0x10178529 */
            ii(0x1017_8515, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8518, 2); if(jnzd(0x1017_8521, 0x7)) goto l_0x1017_8521; /* jnz 0x10178521 */
            ii(0x1017_851a, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_851f, 2); jmpd(0x1017_852e, 0xd); goto l_0x1017_852e; /* jmp 0x1017852e */
        l_0x1017_8521:
            ii(0x1017_8521, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_8524, 2); if(jzd(0x1017_8529, 0x3)) goto l_0x1017_8529; /* jz 0x10178529 */
            ii(0x1017_8526, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8529:
            ii(0x1017_8529, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_852e:
            ii(0x1017_852e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_8530, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_8533, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_8535, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x2e); /* mov word [eax*2+0x10208a40], 0x2e */
            ii(0x1017_853f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_8541, 2); if(jnzd(0x1017_854a, 0x7)) goto l_0x1017_854a; /* jnz 0x1017854a */
            ii(0x1017_8543, 5); mov(ebx, 0x34);                         /* mov ebx, 0x34 */
            ii(0x1017_8548, 2); jmpd(0x1017_8565, 0x1b); goto l_0x1017_8565; /* jmp 0x10178565 */
        l_0x1017_854a:
            ii(0x1017_854a, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_854d, 2); if(jnzd(0x1017_8556, 0x7)) goto l_0x1017_8556; /* jnz 0x10178556 */
            ii(0x1017_854f, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_8554, 2); jmpd(0x1017_8563, 0xd); goto l_0x1017_8563; /* jmp 0x10178563 */
        l_0x1017_8556:
            ii(0x1017_8556, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_8559, 2); if(jzd(0x1017_855e, 0x3)) goto l_0x1017_855e; /* jz 0x1017855e */
            ii(0x1017_855b, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_855e:
            ii(0x1017_855e, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_8563:
            ii(0x1017_8563, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_8565:
            ii(0x1017_8565, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_856c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_856e, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x3a); /* mov word [eax*2+0x10208a42], 0x3a */
            ii(0x1017_8578, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_857a, 2); if(jnzd(0x1017_8583, 0x7)) goto l_0x1017_8583; /* jnz 0x10178583 */
            ii(0x1017_857c, 5); mov(ebx, 0x34);                         /* mov ebx, 0x34 */
            ii(0x1017_8581, 2); jmpd(0x1017_859e, 0x1b); goto l_0x1017_859e; /* jmp 0x1017859e */
        l_0x1017_8583:
            ii(0x1017_8583, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8586, 2); if(jnzd(0x1017_858f, 0x7)) goto l_0x1017_858f; /* jnz 0x1017858f */
            ii(0x1017_8588, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_858d, 2); jmpd(0x1017_859c, 0xd); goto l_0x1017_859c; /* jmp 0x1017859c */
        l_0x1017_858f:
            ii(0x1017_858f, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_8592, 2); if(jzd(0x1017_8597, 0x3)) goto l_0x1017_8597; /* jz 0x10178597 */
            ii(0x1017_8594, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8597:
            ii(0x1017_8597, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_859c:
            ii(0x1017_859c, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_859e:
            ii(0x1017_859e, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_85a5, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_85a7, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_85b1, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_85b3, 2); if(jzd(0x1017_85c9, 0x14)) goto l_0x1017_85c9; /* jz 0x101785c9 */
            ii(0x1017_85b5, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_85b8, 2); if(jnzd(0x1017_85c1, 0x7)) goto l_0x1017_85c1; /* jnz 0x101785c1 */
            ii(0x1017_85ba, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_85bf, 2); jmpd(0x1017_85ce, 0xd); goto l_0x1017_85ce; /* jmp 0x101785ce */
        l_0x1017_85c1:
            ii(0x1017_85c1, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_85c4, 2); if(jzd(0x1017_85c9, 0x3)) goto l_0x1017_85c9; /* jz 0x101785c9 */
            ii(0x1017_85c6, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_85c9:
            ii(0x1017_85c9, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_85ce:
            ii(0x1017_85ce, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_85d0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_85d3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_85d5, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_85df, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_85e1, 2); if(jnzd(0x1017_85ea, 0x7)) goto l_0x1017_85ea; /* jnz 0x101785ea */
            ii(0x1017_85e3, 5); mov(ebx, 0x34);                         /* mov ebx, 0x34 */
            ii(0x1017_85e8, 2); jmpd(0x1017_8605, 0x1b); goto l_0x1017_8605; /* jmp 0x10178605 */
        l_0x1017_85ea:
            ii(0x1017_85ea, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_85ed, 2); if(jnzd(0x1017_85f6, 0x7)) goto l_0x1017_85f6; /* jnz 0x101785f6 */
            ii(0x1017_85ef, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_85f4, 2); jmpd(0x1017_8603, 0xd); goto l_0x1017_8603; /* jmp 0x10178603 */
        l_0x1017_85f6:
            ii(0x1017_85f6, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_85f9, 2); if(jzd(0x1017_85fe, 0x3)) goto l_0x1017_85fe; /* jz 0x101785fe */
            ii(0x1017_85fb, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_85fe:
            ii(0x1017_85fe, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_8603:
            ii(0x1017_8603, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_8605:
            ii(0x1017_8605, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_860c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_860e, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_8618, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_861a, 2); if(jnzd(0x1017_8623, 0x7)) goto l_0x1017_8623; /* jnz 0x10178623 */
            ii(0x1017_861c, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1017_8621, 2); jmpd(0x1017_863e, 0x1b); goto l_0x1017_863e; /* jmp 0x1017863e */
        l_0x1017_8623:
            ii(0x1017_8623, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8626, 2); if(jnzd(0x1017_862f, 0x7)) goto l_0x1017_862f; /* jnz 0x1017862f */
            ii(0x1017_8628, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x1017_862d, 2); jmpd(0x1017_863e, 0xf); goto l_0x1017_863e; /* jmp 0x1017863e */
        l_0x1017_862f:
            ii(0x1017_862f, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_8632, 2); if(jzd(0x1017_8637, 0x3)) goto l_0x1017_8637; /* jz 0x10178637 */
            ii(0x1017_8634, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8637:
            ii(0x1017_8637, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_863c, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_863e:
            ii(0x1017_863e, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_8645, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_8647, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x2d); /* mov word [eax*2+0x10208a40], 0x2d */
            ii(0x1017_8651, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_8653, 2); if(jnzd(0x1017_865c, 0x7)) goto l_0x1017_865c; /* jnz 0x1017865c */
            ii(0x1017_8655, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_865a, 2); jmpd(0x1017_8675, 0x19); goto l_0x1017_8675; /* jmp 0x10178675 */
        l_0x1017_865c:
            ii(0x1017_865c, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_865f, 2); if(jnzd(0x1017_8668, 0x7)) goto l_0x1017_8668; /* jnz 0x10178668 */
            ii(0x1017_8661, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_8666, 2); jmpd(0x1017_8675, 0xd); goto l_0x1017_8675; /* jmp 0x10178675 */
        l_0x1017_8668:
            ii(0x1017_8668, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_866b, 2); if(jzd(0x1017_8670, 0x3)) goto l_0x1017_8670; /* jz 0x10178670 */
            ii(0x1017_866d, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8670:
            ii(0x1017_8670, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_8675:
            ii(0x1017_8675, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_8677, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_867a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_867c, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x5f); /* mov word [eax*2+0x10208a42], 0x5f */
            ii(0x1017_8686, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_8688, 2); if(jnzd(0x1017_8691, 0x7)) goto l_0x1017_8691; /* jnz 0x10178691 */
            ii(0x1017_868a, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1017_868f, 2); jmpd(0x1017_86aa, 0x19); goto l_0x1017_86aa; /* jmp 0x101786aa */
        l_0x1017_8691:
            ii(0x1017_8691, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8694, 2); if(jnzd(0x1017_869d, 0x7)) goto l_0x1017_869d; /* jnz 0x1017869d */
            ii(0x1017_8696, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x1017_869b, 2); jmpd(0x1017_86aa, 0xd); goto l_0x1017_86aa; /* jmp 0x101786aa */
        l_0x1017_869d:
            ii(0x1017_869d, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_86a0, 2); if(jzd(0x1017_86a5, 0x3)) goto l_0x1017_86a5; /* jz 0x101786a5 */
            ii(0x1017_86a2, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_86a5:
            ii(0x1017_86a5, 5); mov(ebx, 0x35);                         /* mov ebx, 0x35 */
        l_0x1017_86aa:
            ii(0x1017_86aa, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_86b1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_86b3, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_86bd, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_86bf, 2); if(jnzd(0x1017_86c8, 0x7)) goto l_0x1017_86c8; /* jnz 0x101786c8 */
            ii(0x1017_86c1, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_86c6, 2); jmpd(0x1017_86e1, 0x19); goto l_0x1017_86e1; /* jmp 0x101786e1 */
        l_0x1017_86c8:
            ii(0x1017_86c8, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_86cb, 2); if(jnzd(0x1017_86d4, 0x7)) goto l_0x1017_86d4; /* jnz 0x101786d4 */
            ii(0x1017_86cd, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_86d2, 2); jmpd(0x1017_86e1, 0xd); goto l_0x1017_86e1; /* jmp 0x101786e1 */
        l_0x1017_86d4:
            ii(0x1017_86d4, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_86d7, 2); if(jzd(0x1017_86dc, 0x3)) goto l_0x1017_86dc; /* jz 0x101786dc */
            ii(0x1017_86d9, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_86dc:
            ii(0x1017_86dc, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_86e1:
            ii(0x1017_86e1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_86e3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_86e6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_86e8, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_86f2, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_86f4, 2); if(jnzd(0x1017_86fd, 0x7)) goto l_0x1017_86fd; /* jnz 0x101786fd */
            ii(0x1017_86f6, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1017_86fb, 2); jmpd(0x1017_8718, 0x1b); goto l_0x1017_8718; /* jmp 0x10178718 */
        l_0x1017_86fd:
            ii(0x1017_86fd, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_8700, 2); if(jnzd(0x1017_8709, 0x7)) goto l_0x1017_8709; /* jnz 0x10178709 */
            ii(0x1017_8702, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_8707, 2); jmpd(0x1017_8716, 0xd); goto l_0x1017_8716; /* jmp 0x10178716 */
        l_0x1017_8709:
            ii(0x1017_8709, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_870c, 2); if(jzd(0x1017_8711, 0x3)) goto l_0x1017_8711; /* jz 0x10178711 */
            ii(0x1017_870e, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_8711:
            ii(0x1017_8711, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_8716:
            ii(0x1017_8716, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_8718:
            ii(0x1017_8718, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_871f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_8721, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_872b, 6); mov(memd_a32[ds, 0x1020_9540], edx);    /* mov [0x10209540], edx */
            ii(0x1017_8731, 1); popd(edi);                              /* pop edi */
            ii(0x1017_8732, 1); popd(esi);                              /* pop esi */
            ii(0x1017_8733, 1); popd(edx);                              /* pop edx */
            ii(0x1017_8734, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_8735, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_8736, 1); retd(); return;                         /* ret */
        }
    }
}
